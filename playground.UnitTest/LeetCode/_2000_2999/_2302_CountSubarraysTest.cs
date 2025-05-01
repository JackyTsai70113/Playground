using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2302_CountSubarraysTest
{
    [Theory]
    [InlineData("[2,1,4,3,5]", 10, 6)]
    [InlineData("[1,1,1]", 5, 5)]
    public void CountSubarrays(string nums, long k, long expected)
    {
        var actual = _2302_CountSubarrays.CountSubarrays(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
