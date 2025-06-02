using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3566_CheckEqualPartitionsTest
{
    [Theory]
    [InlineData("[3,1,6,8,4]", 24, true)]
    [InlineData("[2,5,3,7]", 15, false)]
    [InlineData("[1,9,64]", 24, false)]
    public void MinimumArrayLength(string nums, long target, bool expected)
    {
        var actual = _3566_CheckEqualPartitions.CheckEqualPartitions(nums.ToArr(), target);
        Assert.Equal(expected, actual);
    }
}