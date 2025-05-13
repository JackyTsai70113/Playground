namespace playground.UnitTest.LeetCode._3000_3999;

public class _3238_WinningPlayerCountTest
{
    [Theory]
    [InlineData(4, "[[0,0],[1,0],[1,0],[2,1],[2,1],[2,0]]", 2)]
    [InlineData(5, "[[1,1],[1,2],[1,3],[1,4]]", 0)]
    [InlineData(5, "[[1,1],[2,4],[2,4],[2,4]]", 1)]
    public void WinningPlayerCount(int n, string pick, int expected)
    {
        var actual = _3238_WinningPlayerCount.WinningPlayerCount(n, pick.To2dArr());
        Assert.Equal(expected, actual);
    }
}
