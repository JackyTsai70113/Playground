namespace playground.UnitTest;

public class _2290_MinimumObstaclesTest
{
    [Theory]
    [InlineData("[[0,1,1],[1,1,0],[1,1,0]]", 2)]
    [InlineData("[[0,1,0,0,0],[0,1,0,1,0],[0,0,0,1,0]]", 0)]
    public void MinimumObstacles(string A, int expected)
    {
        var actual = _2290_MinimumObstacles_cs.MinimumObstacles(A.To2dArr());
        Assert.Equal(expected, expected);
    }
}
