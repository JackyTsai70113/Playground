using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2747_CountServersTest
{
    [Theory]
    [InlineData(3, "[[1,3],[2,6],[1,5]]", 5, new int[] { 10, 11 }, new int[] { 1, 2 })]
    [InlineData(3, "[[2,4],[2,1],[1,2],[3,1]]", 2, new int[] { 3, 4 }, new int[] { 0, 1 })]
    public void CountServers(int n, string logs, int x, int[] queries, int[] expected)
    {
        var actual = _2747_CountServers.CountServers(n, logs.To2dArr(), x, queries);
        Assert.Equal(expected, actual);
    }
}
