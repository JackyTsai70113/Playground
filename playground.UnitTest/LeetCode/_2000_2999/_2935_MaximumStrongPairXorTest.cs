using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2935_MaximumStrongPairXorTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", 7)]
    [InlineData("[10,100]", 0)]
    [InlineData("[5,6,25,30]", 7)]
    [InlineData("[500,520,2500,3000]", 1020)]
    public void MaximumStrongPairXor(string nums, int expected)
    {
        var actual = _2935_MaximumStrongPairXor.MaximumStrongPairXor(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}