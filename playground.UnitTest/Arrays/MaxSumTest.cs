using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MaxSumTest
{
    [Theory]
    [InlineData("[[2,1,1],[1,1,0],[0,1,1]]", 7)]
    [InlineData("[[2,1,1],[0,1,1],[1,0,1]]", 7)]
    [InlineData("[[1,1,1,1],[1,1,1,1],[1,1,1,1],[1,1,1,1]]", 7)]
    public void MaxSum(string grid, int expected)
    {
        var actual = MaxSumClass.MaxSum(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
