namespace playground.UnitTest;

public class CountServersTest2747
{
    [Theory]
    [InlineData(3, "[[1,3],[2,6],[1,5]]", 5, new int[] { 10, 11 }, new int[] { 1, 2 })]
    [InlineData(3, "[[2,4],[2,1],[1,2],[3,1]]", 2, new int[] { 3, 4 }, new int[] { 0, 1 })]
    public void CountServers(int n, string logs, int x, int[] queries, int[] expected)
    {
        var actual = CountServers2747.CountServers(n, logs.To2dArr(), x, queries);
        Assert.Equal(expected, actual);
    }
}
