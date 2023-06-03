using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class DifferenceOfSumTest
{
    [Theory]
    [InlineData(new int[] { 1, 15, 6, 3 }, 9)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 0)]
    public void DifferenceOfSum(int[] nums, int expected)
    {
        var actual = DifferenceOfSumClass.DifferenceOfSum(nums);
        Assert.Equal(expected, actual);
    }
}