using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0064_MinPathSumTest
{
    [Theory]
    [InlineData("[[1,3,1],[1,5,1],[4,2,1]]", 7)]
    [InlineData("[[1,2,3],[4,5,6]]", 12)]
    public void MinPathSum(string grid, int expected)
    {
        var actual = _0064_MinPathSum.MinPathSum(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
