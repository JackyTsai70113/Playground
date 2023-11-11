using playground.SlidingWindow;

namespace playground.UnitTest.SlidingWindow;

public class CountServersTest
{
    [Theory]
    [InlineData(3, "[[1,3],[2,6],[1,5]]", 5, new int[] { 10, 11 }, new int[] { 1, 2 })]
    [InlineData(3, "[[1,3],[2,6],[1,5]]", 5, new int[] { 10, 10, 11, 14 }, new int[] { 1, 1, 2, 3 })]
    [InlineData(3, "[[2,4],[2,1],[1,2],[3,1]]", 2, new int[] { 3, 4 }, new int[] { 0, 1 })]
    [InlineData(6, "[[1,21]]", 10, new int[] { 24, 35, 28, 26, 20, 25, 16, 31, 12 }, new int[] { 5, 6, 5, 5, 6, 5, 6, 5, 6 })]
    public void CountServers(int n, string logs, int x, int[] queries, int[] expected)
    {
        var actual = CountServersClass.CountServers(n, logs.To2dArr(), x, queries);
        Assert.Equal(expected, actual);
    }
}
