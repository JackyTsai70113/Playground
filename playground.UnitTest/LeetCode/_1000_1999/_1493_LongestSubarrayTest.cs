using System;
using playground._1400_1499;

namespace playground.UnitTest._1400_1499;

public class _1493_LongestSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 0, 1 }, 3)]
    [InlineData(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }, 5)]
    [InlineData(new int[] { 1, 1, 1 }, 2)]
    public void MaximumElementAfterDecrementingAndRearranging(int[] nums, int expected)
    {
        var actual = _1493_LongestSubarray_cs.LongestSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
