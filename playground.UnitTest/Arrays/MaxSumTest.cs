using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MaxSumTest
{
    [Theory]
    [InlineData("[[2,1,1],[1,1,0],[0,1,1]]", 7)]
    [InlineData("[[2,1,1],[0,1,1],[1,0,1]]", 7)]
    [InlineData("[[1,1,1,1],[1,1,1,1],[1,1,1,1],[1,1,1,1]]", 7)]
    public void MaxSum(string arr, int expected)
    {
        int[][] grid = arr.To2dArr<int>();

        var actual = MaxSumClass.MaxSum(grid);

        Assert.Equal(expected, actual);
    }
}
