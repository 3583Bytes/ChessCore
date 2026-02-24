# ChessCore
Chess Engine Implemented in .net core

Winboard/Xboard Compatible Chess Engine Written in C#/.NET Core.  ChessCore has 2 modes XBoard Protocol which allows you to use Winboard Chess GUI http://hgm.nubati.net or Console mode which shows the current chess board using ASCII.  

To Run type in: dotnet ChessCore.dll

## Build

```powershell
dotnet build ChessCore.sln -nologo
```

## Testing

The repository now includes a dedicated NUnit test project: `ChessCoreEngine.Tests`.

### Run all tests

This includes the depth-5 perft baseline and takes longer.

```powershell
dotnet test ChessCore.sln -nologo
```

### Run fast tests only

This excludes slow tests (currently depth-5 perft).

```powershell
dotnet test ChessCore.sln -nologo --filter "TestCategory!=Slow"
```

### Perft baselines

`PerftBaselineTests` validates move-generation against known start-position node counts:

- Depth 1: `20`
- Depth 2: `400`
- Depth 3: `8902`
- Depth 4: `197281`
- Depth 5: `4865609` (`Slow` category)

### Run perft tests only

Fast perft set (depth 1-4):

```powershell
dotnet test ChessCoreEngine.Tests/ChessCoreEngine.Tests.csproj -nologo --filter "FullyQualifiedName~PerftBaselineTests&FullyQualifiedName~InitialPosition_PerftMatchesKnownCounts"
```

Depth-5 perft only:

```powershell
dotnet test ChessCoreEngine.Tests/ChessCoreEngine.Tests.csproj -nologo --filter "FullyQualifiedName~PerftBaselineTests&FullyQualifiedName~InitialPosition_PerftDepth5_MatchesKnownCount"
```

All perft tests:

```powershell
dotnet test ChessCoreEngine.Tests/ChessCoreEngine.Tests.csproj -nologo --filter "FullyQualifiedName~PerftBaselineTests"
```

## CI Recommendation

For pull requests, run fast validation:

```powershell
dotnet build ChessCore.sln -nologo
dotnet test ChessCore.sln -nologo --filter "TestCategory!=Slow"
```

For scheduled/nightly runs, include full validation:

```powershell
dotnet test ChessCore.sln -nologo
```


# About

This project is a product of a rather rash decision in mid 2008 to learn to program my own Chess Game, hence began my journey into the art of computer chess.  The main goal of the original project was to learn about how computers play chess while producing a chess engine that is easily understood and well documented.  I feel that goal has now been achieved.  As the next step I decided to release the full source code for my chess engine under the MIT license to allow other developers to learn and contribute to further improve & extend my chess engine.

The documentation & tutorial on how to build a chess engine can be accessed in the following 2 formats:

PDF

http://www.adamberent.com/wp-content/uploads/2019/02/GuideToProgrammingChessEngine.pdf

Website

http://adamberent.com/home/chess/computer-chess/




