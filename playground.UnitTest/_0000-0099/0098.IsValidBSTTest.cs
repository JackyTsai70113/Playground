namespace playground.UnitTest;

public class IsValidBSTTest_0098
{
    [Theory]
    [InlineData("[2,1,3]", true)]
    [InlineData("[5,1,4,null,null,3,6]", false)]
    [InlineData("[2,2,2]", false)]
    [InlineData("[5,4,6,null,null,3,7]", false)]
    [InlineData("[-2147483648,null,2147483647]", true)]
    [InlineData("[-2147483648,null,2147483647,-2147483648]", false)]
    [InlineData("[2147483647,-2147483648,null,null,2147483647]", false)]
    public void IsValidBST(string nums, bool expected)
    {
        var actual = IsValidBST_0098.IsValidBST(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
