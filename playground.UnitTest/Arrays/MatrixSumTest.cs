using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MatrixSumTest
{
    [Theory]
    [InlineData("[[7,2,1],[6,4,2],[6,5,3],[3,2,1]]", 15)]
    [InlineData("[[1]]", 1)]
    public void MatrixSum(string nums, int expected)
    {
        var actual = MatrixSumClass.MatrixSum(nums.To2dArr());
        Assert.Equal(expected, actual);
    }
}
