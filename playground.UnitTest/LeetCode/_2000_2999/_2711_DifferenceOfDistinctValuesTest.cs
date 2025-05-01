using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2711_DifferenceOfDistinctValuesTest
{
    [Theory]
    [InlineData("[[1,2,3],[3,1,5],[3,2,1]]", "[[1,1,0],[1,0,1],[0,1,1]]")]
    [InlineData("[[1,2],[3,1],[3,2]]", "[[1,0],[1,1],[0,1]]")]
    [InlineData("[[1,2,3],[3,1,5]]", "[[1,1,0],[0,1,1]]")]
    [InlineData("[[1]]", "[[0]]")]
    public void DifferenceOfDistinctValues(string grid, string expected)
    {
        var actual = _2711_DifferenceOfDistinctValues.DifferenceOfDistinctValues(grid.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
