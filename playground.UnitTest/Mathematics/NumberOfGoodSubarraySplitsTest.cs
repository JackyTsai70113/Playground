using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class NumberOfGoodSubarraySplitsTest
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 0, 1 }, 3)]
    [InlineData(new int[] { 0, 1, 0 }, 1)]
    [InlineData(new int[] { 0, 0, 0 }, 0)]
    public void NumberOfGoodSubarraySplits(int[] nums, int expected)
    {
        var actual = NumberOfGoodSubarraySplitsClass.NumberOfGoodSubarraySplits(nums);
        Assert.Equal(expected, actual);
    }
}
