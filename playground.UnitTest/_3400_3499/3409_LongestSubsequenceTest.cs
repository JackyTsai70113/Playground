using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

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
