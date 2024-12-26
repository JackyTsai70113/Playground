using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

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
