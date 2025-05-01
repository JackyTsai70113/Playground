using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2419_LongestSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 3, 2, 2 }, 2)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 1)]
    [InlineData(new int[] { 96317, 96317, 96317, 96317, 96317, 96317, 96317, 96317, 96317, 279979 }, 1)]
    public void LongestSubarray(int[] nums, int expected)
    {
        var actual = _2419_LongestSubarray.LongestSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
