# Performance baseline

Reference numbers for detecting search-performance regressions. Update this file
whenever you intentionally change something that moves the totals.

## How to reproduce

Always build in Release. Debug is 5–10× slower and useless for measurement.

```powershell
dotnet build ChessCore.sln -c Release -nologo
1..5 | ForEach-Object {
    "bench`nquit" | dotnet run -c Release --no-build --project ChessCore
} | Tee-Object bench.log
```

Take the median of the **total** line across the runs. Single runs lie because of
JIT warmup and OS scheduling jitter; the median of five is stable enough.

## Current baseline

Captured on .NET 10.0.7 / Windows 11 x64 after the search bug fixes
(commit `7ce9e74`: inverted SEE, check-extension precedence,
`NodesQuiessence` reset) **and** the evaluation fixes in `Evaluation.cs`
(a-file passed-pawn typo, symmetric pawn-advance weights, passed-pawn
definition now requires no enemy pawn on either adjacent file).

```
total nodes 920_896    (deterministic — same across all runs)
total time  ~6_700 ms  (median; range 5.9–8.2 s)
total NPS   ~140_000   (median; range 112K–155K)
```

Per-position breakdown from one representative run:

```
Start         depth 6 nodes 132105 time  903ms nps  146295
Kiwipete      depth 5 nodes 404847 time 2677ms nps  151231
Endgame       depth 6 nodes  35360 time   87ms nps  406436
BK.01         depth 4 nodes 345217 time 2241ms nps  154045
KRk endgame   depth 7 nodes    981 time    1ms (sub-ms — discard NPS)
Promotion     depth 6 nodes   2386 time    2ms (sub-ms — discard NPS)
```

> **Note**: per-position numbers are useful for spotting regressions in a *single*
> position type (e.g. endgames), but only the **total** is stable enough to gate
> changes against. Per-position depth varies because iterative deepening's
> `ModifyDepth` boosts depth in low-piece-count or low-mobility positions.

### Prior baselines

| Commit / state | Total nodes | Total time (median) |
|---|---|---|
| Post-search-fixes (`7ce9e74`) | 999,890 | ~9.5 s |
| Post-eval-fixes (current) | 920,896 | ~6.7 s |

The eval fixes shrank the tree ~8% — same depth, fewer positions visited because
the evaluation produces more decisive scores and alpha-beta finds more cutoffs.
Bench measures node count and raw speed, **not playing strength**: confirm with
a head-to-head Cute Chess match before treating the change as a strength gain.

## How to interpret comparisons

After a change, re-run the procedure above and compare to the baseline.

| What moved | Likely meaning |
|---|---|
| Total nodes ↑, time same | Search tree grew (worse move ordering, weaker pruning) — *bad* |
| Total nodes ↓, time same | Search tree shrank (better move ordering, stronger pruning) — *good* |
| Total nodes same, time ↑ | Raw per-node work got more expensive (allocations, codegen) — *bad* |
| Total nodes same, time ↓ | Raw per-node work got cheaper — *good* |
| Both ↑ together | Could be either: more nodes visited, AND each more expensive |
| Both ↓ together | Pure win |

Total-node changes that come with **deeper `depth` reached** in the per-position
breakdown are usually fine — iterative deepening just chose to search one ply
further. Look at `nodes / depth_reached` if you want depth-normalized comparison.

## What `bench` does *not* measure

- **Playing strength.** Two engines can hit identical bench numbers and yet one
  wins 70% of games. For real strength changes, run a head-to-head match in
  [Cute Chess](https://cutechess.com/) tournament mode (Tools → New Tournament).
  A few hundred games at a fixed short time control (60s + 0.6s increment is a
  reasonable starting point) gives a usable Elo delta.
- **Move-generation speed.** Bench mixes search + evaluation + quiescence + movegen.
  For movegen-only timing, time the perft tests:
  ```powershell
  dotnet test ChessCore.sln -c Release --filter "FullyQualifiedName~PerftBaselineTests"
  ```
  Depth-5 perft is 4,865,609 nodes of pure move generation.
- **Time-control behaviour.** Bench searches to a fixed depth, never to a time
  budget. If you change the wtime/btime → depth mapping in `UciProtocol.PickDepth`,
  bench won't see it. Test with `go movetime 3000` from a few positions instead.
