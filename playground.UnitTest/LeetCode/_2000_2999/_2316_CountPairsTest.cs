using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2316_CountPairsTest
{
    [Theory]
    [InlineData(3, "[[0, 1], [0, 2], [1, 2]]", 0)]
    [InlineData(7, "[[0, 2], [0, 5], [2, 4], [1, 6], [5, 4]]", 14)]
    public void CountPairs(int n, string edges, int expected)
    {
        var actual = _2316_CountPairs.CountPairs(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
