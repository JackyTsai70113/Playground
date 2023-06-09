using playground.DirectedWeightedGraph;

namespace playground.UnitTest.DirectedWeightedGraph;

public class NetworkDelayTimeTest
{
    [Theory]
    [InlineData("[[2,1,1],[2,3,1],[3,4,1]]", 4, 2, 2)]
    [InlineData("[[1,2,1]]", 2, 1, 1)]
    [InlineData("[[1,2,1]]", 2, 2, -1)]
    [InlineData("[[1,2,1],[2,3,2],[1,3,2]]", 3, 1, 2)]
    public void NetworkDelayTime(string times, int n, int k, int expected)
    {
        var actual = NetworkDelayTimeClass.NetworkDelayTime(times.To2dArr(), n, k);
        Assert.Equal(expected, actual);
    }
}
