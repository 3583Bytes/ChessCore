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

Captured on .NET 10.0.7 / Windows 11 x64 after a round of eval/search cleanup
and book fixes on top of `cdbe753`:

- `Evaluation.cs`: removed duplicate endgame-check bonus, fixed pawn-wall king
  exclusion (e1/e8 only, not d1/d8), pooled the per-call `pawnCount` arrays
  (no allocation per eval), corrected the insufficient-material classifier
  (KNvKN and KBvKB are now flagged insufficient), removed dead mate-sentinel
  branch (mate is owned by `Search`), tightened bishop-pair bonus to fire
  exactly once, and rewrote the black-piece PST mirror as `position ^ 56`.
- `Search.cs`: removed the root-level "return on first mate found"
  short-circuit so alpha-beta's depth-adjusted mate scores actually pick the
  shortest mate. Side-effect: `plyDepthReached` increases by 1 in mate-bearing
  bench positions (the old short-circuit returned before the final `++`).
- `Engine.cs`: `InitiateBoard` now resets `MoveHistory` / `CurrentGameBook` /
  undo slots — previously stale across UCI `position` commands, which made
  the engine emit `bestmove 0000` after a few moves of normal play.
- `Book.cs`: the startpos entry was constructed but never `Add`-ed; first move
  from `position startpos` now hits the book instead of running a search.
  Removed a duplicate `Add` at the very end of the book.

```
total nodes 792_281    (deterministic — same across all runs)
total time  ~3_300 ms  (median; range 2.9–3.3 s)
total NPS   ~243_000   (median; range 239K–276K)
```

Per-position breakdown from one representative run:

```
Start         depth 0 nodes      0 time   12ms nps        0  (book hit)
Kiwipete      depth 5 nodes 407514 time 1742ms nps   233934
Endgame       depth 6 nodes  35325 time   50ms nps   706500
BK.01         depth 5 nodes 346075 time 1349ms nps   256541
KRk endgame   depth 7 nodes    981 time    0ms (sub-ms — discard NPS)
Promotion     depth 7 nodes   2386 time    1ms (sub-ms — discard NPS)
```

> **Note**: per-position numbers are useful for spotting regressions in a *single*
> position type (e.g. endgames), but only the **total** is stable enough to gate
> changes against. Per-position depth varies because iterative deepening's
> `ModifyDepth` boosts depth in low-piece-count or low-mobility positions.

### Prior baselines

| Commit / state | Total nodes | Total time (median) |
|---|---|---|
| Post-search-fixes (`7ce9e74`) | 999,890 | ~9.5 s |
| Post-eval-fixes (`cdbe753`) | 920,896 | ~6.7 s |
| Post-eval-cleanup + book fixes (current) | 792,281 | ~3.3 s |

The biggest chunk of the latest drop (~132K nodes) is the `Start` bench position
becoming a book hit instead of a depth-6 search — measured search performance on
the *other* positions actually moved by only a few thousand nodes total
(BK.01 +858, Kiwipete +2667, Endgame −35). The time-budget improvement (~6.7s →
~3.3s) reflects both the missing Start search and the per-eval allocation cleanup
removing `new short[8]` × 2 from the hot path.

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
