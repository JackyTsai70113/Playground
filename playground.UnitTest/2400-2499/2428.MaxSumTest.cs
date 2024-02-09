namespace playground.UnitTest;

public class MaxSumTest2428
{
    [Theory]
    [InlineData("[[6,2,1,3],[4,2,1,5],[9,2,8,7],[4,1,2,9]]", 30)]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", 35)]
    [InlineData("[[2,1,1],[1,1,0],[0,1,1]]", 7)]
    [InlineData("[[2,1,1],[0,1,1],[1,0,1]]", 7)]
    [InlineData("[[1,1,1,1],[1,1,1,1],[1,1,1,1],[1,1,1,1]]", 7)]
    public void MaxSum(string grid, int expected)
    {
        var actual = MaxSum2428.MaxSum(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
