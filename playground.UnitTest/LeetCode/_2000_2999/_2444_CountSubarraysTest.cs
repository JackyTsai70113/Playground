using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2444_CountSubarraysTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 2, 7, 5 }, 1, 5, 2)]
    [InlineData(new int[] { 1, 3, 5, 2, -1, 5 }, 1, 5, 2)]
    [InlineData(new int[] { 1, 1, 1, 1 }, 1, 1, 10)]
    public void CountSubarrays(int[] nums, int minK, int maxK, long expected)
    {
        var actual = _2444_CountSubarrays.CountSubarrays(nums, minK, maxK);
        Assert.Equal(expected, actual);
    }
}
