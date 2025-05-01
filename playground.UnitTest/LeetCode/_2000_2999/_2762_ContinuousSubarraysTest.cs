using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2762_ContinuousSubarraysTest
{
    [Theory]
    [InlineData(new int[] { 5, 4, 2, 4 }, 8)]
    [InlineData(new int[] { 1, 2, 3 }, 6)]
    public void ContinuousSubarrays(int[] nums, int expected)
    {
        var actual = _2762_ContinuousSubarrays.ContinuousSubarrays(nums);
        Assert.Equal(expected, actual);
    }
}
