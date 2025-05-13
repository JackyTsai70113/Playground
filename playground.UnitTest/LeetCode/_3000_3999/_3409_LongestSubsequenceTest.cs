using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3409_LongestSubsequenceTest
{
    [Theory]
    [InlineData(new int[] { 68, 83, 52, 70, 52 }, 4)]
    public void MinStartingIndex(int[] nums, int expected)
    {
        var actual = _3409_LongestSubsequence.LongestSubsequence(nums);
        Assert.Equal(expected, actual);
    }
}
