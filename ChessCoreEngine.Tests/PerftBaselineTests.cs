using ChessEngine.Engine;
using NUnit.Framework;

namespace ChessCoreEngine.Tests;

[TestFixture]
public class PerftBaselineTests
{
    private static readonly string InitialFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

    [TestCase(1, 20)]
    [TestCase(2, 400)]
    [TestCase(3, 8902)]
    [TestCase(4, 197281)]
    public void InitialPosition_PerftMatchesKnownCounts(int depth, long expectedNodes)
    {
        var engine = new Engine(InitialFen);
        var result = engine.RunPerformanceTest(depth);

        Assert.That(result.Nodes, Is.EqualTo(expectedNodes));
    }

    [Test]
    [Category("Slow")]
    public void InitialPosition_PerftDepth5_MatchesKnownCount()
    {
        var engine = new Engine(InitialFen);
        var result = engine.RunPerformanceTest(5);

        Assert.That(result.Nodes, Is.EqualTo(4865609));
    }
}
