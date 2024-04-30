namespace playground.UnitTest;

public class MinimumTimeTest2577
{
    [Theory]
    [InlineData("[[0,1,2],[0,1,100]]", 101)]
    [InlineData("[[0,2,4],[3,2,1],[1,0,4]]", -1)]
    [InlineData("[[0,1,3,2],[5,1,2,5],[4,3,8,6]]", 7)]
    [InlineData("[[0,1,2,100],[100,4,3,8],[100,100,100,9]]", 9)]
    [InlineData("[[0,1,2,100],[100,4,3,4],[100,100,100,9]]", 9)]
    [InlineData("[[0,1,1000],[3,2,1000],[1000,1000,1000]]", 1002)]
    public void MinimumTime(string grid, int expected)
    {
        var actual = MinimumTime2577.MinimumTime(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
