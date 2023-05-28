using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class DifferenceOfDistinctValuesTest
{
    [Theory]
    [InlineData("[[1,2,3],[3,1,5],[3,2,1]]", "[[1,1,0],[1,0,1],[0,1,1]]")]
    [InlineData("[[1,2],[3,1],[3,2]]", "[[1,0],[1,1],[0,1]]")]
    [InlineData("[[1,2,3],[3,1,5]]", "[[1,1,0],[0,1,1]]")]
    [InlineData("[[1]]", "[[0]]")]
    public void Test1(string grid, string expected)
    {
        var actual = DifferenceOfDistinctValuesClass.DifferenceOfDistinctValues(grid.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
