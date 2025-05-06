using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2461_MaximumSubarraySumTest
{
    [Theory]
    [InlineData(new int[] { 1, 5, 4, 2, 9, 9, 9 }, 3, 15)]
    [InlineData(new int[] { 4, 4, 4 }, 3, 0)]
    [InlineData(new int[] { 1, 2, 2 }, 2, 3)]
    [InlineData(new int[] { 1, 2, 2 }, 5, 0)]
    public void MaximumSubarraySum(int[] nums, int k, long expected)
    {
        var actual = _2461_MaximumSubarraySum.MaximumSubarraySum(nums, k);
        Assert.Equal(expected, actual);
    }
}
