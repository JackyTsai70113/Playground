using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0907_SumSubarrayMinsTest
{
    [Theory]
    [InlineData("[3,1,2,4]", 17)]
    [InlineData("[11,81,94,43,3]", 444)]
    public void SumSubarrayMins(string nums, int expected)
    {
        var actual = _0907_SumSubarrayMins.SumSubarrayMins(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
