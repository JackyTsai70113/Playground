using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0909_SnakesAndLaddersTest
{
    [Theory]
    [InlineData("[[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,35,-1,-1,13,-1],[-1,-1,-1,-1,-1,-1],[-1,15,-1,-1,-1,-1]]", 4)]
    [InlineData("[[1,1,-1],[1,1,1],[-1,1,1]]", -1)]
    [InlineData("[[-1,-1],[-1,3]]", 1)]
    public void MinScoreTriangulation(string A, int expected)
    {
        int actual = new _0909_SnakesAndLadders().SnakesAndLadders(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
