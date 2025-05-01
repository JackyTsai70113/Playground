using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0662_WidthOfBinaryTreeTest
{
    [Theory]
    [InlineData("[1,3,2,5,3,null,9]", 4)]
    [InlineData("[1,3,2,5]", 2)]
    [InlineData("[1,1,1,1,1,1,1,null,null,null,1,null,null,null,null,2,2,2,2,2,2,2,null,2,null,null,2,null,2]", 8)]
    public void WidthOfBinaryTree2(string root, int expected)
    {
        var actual = _0662_WidthOfBinaryTree.WidthOfBinaryTree(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
