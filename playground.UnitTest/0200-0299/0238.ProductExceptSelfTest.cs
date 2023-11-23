namespace playground.UnitTest;

public class ProductExceptSelfTest
{
    [Theory]
    [InlineData("[1,2,3,4]", "[24,12,8,6]")]
    [InlineData("[-1,1,0,-3,3]", "[0,0,9,0,0]")]
    [InlineData("[0,0,3]", "[0,0,0]")]
    public void ProductExceptSelf(string nums, string expected)
    {
        var actual = ProductExceptSelf_0238.ProductExceptSelf(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[1,2,3,4]", "[24,12,8,6]")]
    [InlineData("[-1,1,0,-3,3]", "[0,0,9,0,0]")]
    public void ProductExceptSelf2(string nums, string expected)
    {
        var actual = ProductExceptSelf_0238.ProductExceptSelf2(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
