using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0136_SingleNumberTest
{
    [Theory]
    [InlineData("[2,2,1]", 1)]
    [InlineData("[4,1,2,1,2]", 4)]
    [InlineData("[1]", 1)]
    public void SingleNumber(string nums, int expected)
    {
        var actual = _0136_SingleNumber.SingleNumber(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
