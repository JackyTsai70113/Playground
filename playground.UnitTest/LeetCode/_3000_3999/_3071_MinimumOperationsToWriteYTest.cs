using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3071_MinimumOperationsToWriteYTest
{
    [Theory]
    [InlineData("[[1,2,2],[1,1,0],[0,1,0]]", 3)]
    [InlineData("[[0,1,0,1,0],[2,1,0,1,2],[2,2,2,0,1],[2,2,2,2,2],[2,1,2,2,2]]", 12)]
    public void MinimumOperationsToWriteY(string grid, int expected)
    {
        var actual = _3071_MinimumOperationsToWriteY.MinimumOperationsToWriteY(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
