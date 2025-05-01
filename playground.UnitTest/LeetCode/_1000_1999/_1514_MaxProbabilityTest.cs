namespace playground.UnitTest;

public class _1514_MaxProbabilityTest
{
    [Theory]
    [InlineData(3, "[[0,1],[1,2],[0,2]]", new double[] { 0.5, 0.5, 0.2 }, 0, 2, 0.25)]
    [InlineData(3, "[[0,1],[1,2],[0,2]]", new double[] { 0.5, 0.5, 0.3 }, 0, 2, 0.3)]
    [InlineData(3, "[[0,1]]", new double[] { 0.5 }, 0, 2, 0)]
    public void NumWaterBottles
    (int n, string edges, double[] succProb, int start, int end, double expected)
    {
        var actual = _1514_MaxProbability.MaxProbability(n, edges.To2dArr(), succProb, start, end);
        Assert.Equal(expected, actual);
    }
}
