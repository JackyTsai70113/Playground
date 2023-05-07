using playground.UndirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.UndirectGraph;

public class CountPairsTest
{
    [Theory]
    [InlineData(3, "[[0, 1], [0, 2], [1, 2]]", 0)]
    [InlineData(7, "[[0, 2], [0, 5], [2, 4], [1, 6], [5, 4]]", 14)]
    public void CountPairs(int n, string str, int expect)
    {
        var edges = str.To2dArr<int>();

        long result = CountPairsClass.CountPairs(n, edges);

        Assert.Equal(expect, result);
    }
}
