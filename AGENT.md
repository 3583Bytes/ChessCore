# AGENT.md

## Project Overview
- **Name:** ChessCore
- **Language/Runtime:** C# / .NET 8
- **Solution:** `ChessCore.sln`
- **Projects:**
  - `ChessCore` (console executable, xboard/winboard style command loop)
  - `ChessCoreEngine` (engine/search/evaluation library)

## Architecture Summary
- `ChessCore/Program.cs`: protocol loop, command parsing, console output, board rendering.
- `ChessCoreEngine/Engine.cs`: high-level engine API, move validation/execution, opening book integration, AI search entrypoint.
- `ChessCoreEngine/Search.cs`: iterative deepening + alpha-beta + quiescence + killer move heuristics.
- `ChessCoreEngine/Board.cs`: board state, FEN parsing/serialization, move application helpers.
- `ChessCoreEngine/Evaluation.cs`: position scoring.
- `ChessCoreEngine/PieceValidMoves.cs`: legal move generation.
- `ChessCoreEngine/Test.cs`: NUnit-decorated correctness/performance tests.

## Build And Validation
- Build solution:
  - `dotnet build ChessCore.sln -nologo`
- Current status (review run):
  - Build succeeds with 0 warnings and 0 errors.
- Test execution:
  - `dotnet test ChessCore.sln -nologo` currently discovers no runnable test project.

## Technical Review Findings

### High Priority
1. **`SaveGame` / `LoadGame` are stubbed but return success**
   - File: `ChessCoreEngine/FileIO.cs`
   - Evidence: methods are largely commented out while returning `true` (`return true;` lines 93 and 144).
   - Risk: callers can assume persistence worked when it did not.

2. **No executable automated test project wired into `dotnet test`**
   - Files: `ChessCoreEngine/Test.cs`, `ChessCoreEngine/ChessCoreEngine.csproj`
   - Evidence: 10 `[Test]` attributes exist, but tests live in engine library project; csproj only references NUnit package.
   - Risk: CI/local test command gives false confidence.

### Medium Priority
3. **`GetBestMove()` mutates board state unexpectedly**
   - File: `ChessCoreEngine/Engine.cs`
   - Evidence: inline note at line 904 says `AiPonderMove` modifies board though API suggests query behavior.
   - Risk: API consumers can get side effects from a read-like call.

4. **`FastCopy()` mutates source board attack arrays instead of clone arrays**
   - File: `ChessCoreEngine/Board.cs:733-734`
   - Evidence: writes `WhiteAttackBoard = new bool[64]; BlackAttackBoard = new bool[64];` on current instance.
   - Risk: subtle state corruption/perf issues during search.

### Low Priority
5. **Command loop in `Program.cs` has duplicated branches and brittle parsing**
   - Duplicates:
     - `remove` at lines 93 and 97
     - `otim` at lines 184 and 188
     - `setboard` at lines 212 and 224
     - `edit` at lines 76 and 228
   - Risk: maintenance overhead and accidental behavior divergence.

6. **Timing output appears incorrect**
   - File: `ChessCore/Program.cs:407`
   - Evidence: `ts.Seconds * 100` is printed as elapsed metric.
   - Risk: inaccurate protocol/performance reporting.

## Recommended Remediation Order
1. Implement/repair `SaveGame` and `LoadGame`, or make them explicitly return `false`/throw `NotSupportedException` until implemented.
2. Create a dedicated test project (for example `ChessCoreEngine.Tests`) and move or reference test cases so `dotnet test` runs in CI.
3. Separate read-only search (`FindBestMove`) from move-application (`ApplyBestMove`) in engine API.
4. Fix `Board.FastCopy()` to initialize clone arrays (`clonedBoard.WhiteAttackBoard` / `clonedBoard.BlackAttackBoard`).
5. Refactor `Program.cs` command parser into a command-dispatch map and remove duplicated branches.
6. Replace timing metric with milliseconds (`ts.TotalMilliseconds` cast/format as required by protocol).

## Conventions For Future Agents
- Keep engine move legality and board mutation behavior explicit; avoid hidden side effects in query-style methods.
- When editing search or board logic, run at least:
  - `dotnet build ChessCore.sln -nologo`
  - `dotnet test ChessCore.sln -nologo` (after test project is added)
- Prefer small, isolated commits by concern:
  - API semantics
  - board/search correctness
  - protocol/CLI behavior
- Preserve protocol compatibility (`xboard` command handling and `move` output format).

## Quick Start Commands
- Build: `dotnet build ChessCore.sln -nologo`
- Run engine: `dotnet run --project ChessCore/ChessCore.csproj`
- Publish examples from repo docs:
  - `dotnet publish -c Release -r win10-x64`
  - `dotnet publish -c Release -r osx.10.11-x64`
