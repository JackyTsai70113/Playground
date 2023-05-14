using playground.Arrays;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Arrays;

public class MatrixSumTest
{
    [Theory]
    [InlineData("[[7,2,1],[6,4,2],[6,5,3],[3,2,1]]", 15)]
    [InlineData("[[1]]", 1)]
    public void MatrixSum(string numsStr, int expected)
    {
        var nums = numsStr.To2dArr<int>();
        var actual = MatrixSumClass.MatrixSum(nums);
        Assert.Equal(expected, actual);
    }
}
