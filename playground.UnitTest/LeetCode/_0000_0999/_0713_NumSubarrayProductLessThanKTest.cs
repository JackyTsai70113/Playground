using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0713_NumSubarrayProductLessThanKTest
{
    [Theory]
    [InlineData(new int[] { 10, 5, 2, 6 }, 100, 8)]
    [InlineData(new int[] { 10, 5, 2, 6 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 3 }, 0, 0)]
    public void MaximumElementAfterDecrementingAndRearranging(int[] nums, int k, int expected)
    {
        var actual = _0713_NumSubarrayProductLessThanK.NumSubarrayProductLessThanK(nums, k);
        Assert.Equal(expected, actual);
    }
}
