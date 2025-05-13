using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3392_CountSubarraysTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 4, 1 }, 1)]
    [InlineData(new int[] { 1, 1, 1 }, 0)]
    public void FindMinimumTime(int[] nums, int expected)
    {
        var actual = _3392_CountSubarrays.CountSubarrays(nums);
        Assert.Equal(expected, actual);
    }
}
