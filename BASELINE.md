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

Captured on .NET 10.0.7 / Windows 11 x64 after the search bug fixes in
commit `7ce9e74` (inverted SEE, check-extension precedence,
`NodesQuiessence` reset).

```
total nodes 999_890    (deterministic — same across all runs)
total time  ~9_500 ms  (median; range 7.1–12.7 s)
total NPS   ~105_000   (median; range 78K–140K)
```

Per-position breakdown from one representative run:

```
Start         depth 6 nodes 133527 time 1034ms nps  129136
Kiwipete      depth 5 nodes 451400 time 3078ms nps  146653
Endgame       depth 6 nodes  36404 time   85ms nps  428282
BK.01         depth 4 nodes 375192 time 2319ms nps  161790
KRk endgame   depth 7 nodes    981 time    0ms (sub-ms — discard NPS)
Promotion     depth 6 nodes   2386 time    2ms (sub-ms — discard NPS)
```

> **Note**: per-position numbers are useful for spotting regressions in a *single*
> position type (e.g. endgames), but only the **total** is stable enough to gate
> changes against. Per-position depth varies because iterative deepening's
> `ModifyDepth` boosts depth in low-piece-count or low-mobility positions.

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
