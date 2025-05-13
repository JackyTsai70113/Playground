using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1905_CountSubIslandsTest
{
    [Theory]
    [InlineData(
        "[[1,1,1,0,0],[0,1,1,1,1],[0,0,0,0,0],[1,0,0,0,0],[1,1,0,1,1]]",
        "[[1,1,1,0,0],[0,0,1,1,1],[0,1,0,0,0],[1,0,1,1,0],[0,1,0,1,0]]",
        3
    )]
    [InlineData(
        "[[1,0,1,0,1],[1,1,1,1,1],[0,0,0,0,0],[1,1,1,1,1],[1,0,1,0,1]]",
        "[[0,0,0,0,0],[1,1,1,1,1],[0,1,0,1,0],[0,1,0,1,0],[1,0,0,0,1]]",
        2
    )]
    public void CountSubIslands(string A1, string A2, int expected)
    {
        var actual = _1905_CountSubIslands.CountSubIslands(A1.To2dArr(), A2.To2dArr());
        Assert.Equal(expected, actual);
    }
}
