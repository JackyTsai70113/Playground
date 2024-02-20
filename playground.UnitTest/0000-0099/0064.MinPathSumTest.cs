namespace playground.UnitTest;

public class MinPathSumTest0064
{
    [Theory]
    [InlineData("[[1,3,1],[1,5,1],[4,2,1]]", 7)]
    [InlineData("[[1,2,3],[4,5,6]]", 12)]
    public void MinPathSum(string grid, int expected)
    {
        var actual = MinPathSum0064.MinPathSum(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
