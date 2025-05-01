using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0965_IsUnivalTreeTest
{
    [Theory]
    [InlineData("[1,1,1,1,1,null,1]", true)]
    [InlineData("[2,2,2,5,2]", false)]
    [InlineData("[2,2,2,2,5]", false)]
    public void IsUnivalTree(string root, bool expected)
    {
        var actual = _0965_IsUnivalTree.IsUnivalTree(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
