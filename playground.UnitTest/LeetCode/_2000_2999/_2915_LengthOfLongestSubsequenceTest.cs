using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2915_LengthOfLongestSubsequenceTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 9, 3)]
    [InlineData(new int[] { 4, 1, 3, 2, 1, 5 }, 7, 4)]
    [InlineData(new int[] { 1, 1, 5, 4, 5 }, 3, -1)]
    public void LengthOfLongestSubsequence(IList<int> nums, int target, int expected)
    {
        int actual;
        actual = _2915_LengthOfLongestSubsequence.LengthOfLongestSubsequence_TopDown(nums, target);
        Assert.Equal(expected, actual);
        actual = _2915_LengthOfLongestSubsequence.LengthOfLongestSubsequence_BottomUp(nums, target);
        Assert.Equal(expected, actual);
    }
}
