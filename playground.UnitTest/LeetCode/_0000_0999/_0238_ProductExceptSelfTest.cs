using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0238_ProductExceptSelfTest
{
    [Theory]
    [InlineData("[1,2,3,4]", "[24,12,8,6]")]
    [InlineData("[-1,1,0,-3,3]", "[0,0,9,0,0]")]
    [InlineData("[0,0,3]", "[0,0,0]")]
    public void ProductExceptSelf(string nums, string expected)
    {
        var actual = _0238_ProductExceptSelf.ProductExceptSelf(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[1,2,3,4]", "[24,12,8,6]")]
    [InlineData("[-1,1,0,-3,3]", "[0,0,9,0,0]")]
    public void ProductExceptSelf2(string nums, string expected)
    {
        var actual = _0238_ProductExceptSelf.ProductExceptSelf2(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
