using System;
using playground._0700_0799;

namespace playground.UnitTest._0700_0799;

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
