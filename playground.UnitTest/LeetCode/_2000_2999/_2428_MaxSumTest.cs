using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2428_MaxSumTest
{
    [Theory]
    [InlineData("[[6,2,1,3],[4,2,1,5],[9,2,8,7],[4,1,2,9]]", 30)]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", 35)]
    [InlineData("[[2,1,1],[1,1,0],[0,1,1]]", 7)]
    [InlineData("[[2,1,1],[0,1,1],[1,0,1]]", 7)]
    [InlineData("[[1,1,1,1],[1,1,1,1],[1,1,1,1],[1,1,1,1]]", 7)]
    public void MaxSum(string grid, int expected)
    {
        var actual = _2428_MaxSum.MaxSum(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
