using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0098_IsValidBSTTest
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
        var actual = _0098_IsValidBST.IsValidBST(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
