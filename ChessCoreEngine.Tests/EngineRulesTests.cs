using ChessEngine.Engine;
using NUnit.Framework;
using System.Linq;

namespace ChessCoreEngine.Tests;

[TestFixture]
public class EngineRulesTests
{
    private static string FenCore(string fen)
    {
        return string.Join(" ", fen.Split(' ').Take(4));
    }

    [Test]
    public void InitialPosition_HasExpectedFen()
    {
        var engine = new Engine();
        Assert.That(engine.FEN, Is.EqualTo("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1"));
    }

    [Test]
    public void NotationParser_HandlesCoordinateNotation()
    {
        byte srcCol = 0;
        byte srcRow = 0;
        byte dstCol = 0;
        byte dstRow = 0;

        Assert.That(MoveContent.ParseAN("a8h1", ref srcCol, ref srcRow, ref dstCol, ref dstRow), Is.True);
        Assert.That(MoveContent.ParseAN("abc", ref srcCol, ref srcRow, ref dstCol, ref dstRow), Is.False);
    }

    [Test]
    public void IllegalMove_ThatExposesKing_IsRejected()
    {
        var fen = "4r3/8/8/8/8/8/4R3/4K3 w - - 0 1";
        var engine = new Engine(fen);

        var moved = engine.MovePieceAN("e2f2");

        Assert.That(moved, Is.False);
        Assert.That(FenCore(engine.FEN), Is.EqualTo(FenCore(fen)));
    }

    [Test]
    public void EnPassantCapture_IsAppliedCorrectly()
    {
        var engine = new Engine("4k3/8/8/3pP3/8/8/8/4K3 w - d6 0 1");

        var moved = engine.MovePieceAN("e5d6");

        Assert.That(moved, Is.True);
        Assert.That(FenCore(engine.FEN), Is.EqualTo("4k3/8/3P4/8/8/8/8/4K3 b - -"));
    }

    [Test]
    public void WhiteKingSideCastle_IsAppliedCorrectly()
    {
        var engine = new Engine("r3k2r/8/8/8/8/8/8/R3K2R w KQkq - 0 1");

        var moved = engine.MovePieceAN("e1g1");

        Assert.That(moved, Is.True);
        Assert.That(engine.FEN, Is.EqualTo("r3k2r/8/8/8/8/8/8/R4RK1 b kq - 1 1"));
    }

    [Test]
    public void Promotion_ToQueen_IsAppliedCorrectly()
    {
        var engine = new Engine("4k3/7P/8/8/8/8/8/4K3 w - - 0 1");

        var moved = engine.MovePieceAN("h7h8");

        Assert.That(moved, Is.True);
        Assert.That(FenCore(engine.FEN), Is.EqualTo("4k2Q/8/8/8/8/8/8/4K3 b - -"));
    }

    [Test]
    public void FoolsMate_SetsCheckmateState()
    {
        var engine = new Engine();
        engine.MovePieceAN("f2f3");
        engine.MovePieceAN("e7e5");
        engine.MovePieceAN("g2g4");
        engine.MovePieceAN("d8h4");

        Assert.That(engine.GetWhiteMate(), Is.True);
        Assert.That(engine.IsGameOver(), Is.True);
        Assert.That(engine.IsTie(), Is.False);
    }

    [Test]
    public void FiftyMoveRule_TriggersAfterOneHundredHalfMoves()
    {
        var engine = new Engine("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");

        for (var i = 0; i < 24; i++)
        {
            engine.MovePieceAN("b1c3");
            engine.MovePieceAN("b8c6");
            engine.MovePieceAN("c3b1");
            engine.MovePieceAN("c6b8");
            Assert.That(engine.FiftyMove, Is.False);
        }

        engine.MovePieceAN("b1c3");
        engine.MovePieceAN("b8c6");
        engine.MovePieceAN("c3b1");
        engine.MovePieceAN("c6b8");

        Assert.That(engine.FiftyMove, Is.True);
        Assert.That(engine.IsTie(), Is.True);
    }
}
