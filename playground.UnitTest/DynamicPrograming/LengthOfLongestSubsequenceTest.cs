using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class LengthOfLongestSubsequenceTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 9, 3)]
    [InlineData(new int[] { 4, 1, 3, 2, 1, 5 }, 7, 4)]
    [InlineData(new int[] { 1, 1, 5, 4, 5 }, 3, -1)]
    public void LengthOfLongestSubsequence(IList<int> nums, int target, int expected)
    {
        var actual = LengthOfLongestSubsequenceClass.LengthOfLongestSubsequence(nums, target);
        Assert.Equal(expected, actual);
    }
}
