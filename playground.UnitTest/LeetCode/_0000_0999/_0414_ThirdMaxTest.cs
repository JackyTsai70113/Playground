using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0414_ThirdMaxTest
{
    [Theory]
    [InlineData("[3,2,1]", 1)]
    [InlineData("[1,2]", 2)]
    [InlineData("[4,3,1,2]", 2)]
    [InlineData("[4,2,3]", 2)]
    [InlineData("[3,4,2]", 2)]
    [InlineData("[2,2,3,1]", 1)]
    [InlineData("[5,2,2]", 5)]
    [InlineData("[1,2,-2147483648]", -2147483648)]
    public void ThirdMax(string nums, int expected)
    {
        var actual = _0414_ThirdMax.ThirdMax(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
