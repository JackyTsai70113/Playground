using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0137_SingleNumberTest
{
    [Theory]
    [InlineData("[2,2,3,2]", 3)]
    [InlineData("[0,1,0,1,0,1,99]", 99)]
    public void SingleNumber(string nums, int expected)
    {
        var actual = _0137_SingleNumber.SingleNumber(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
