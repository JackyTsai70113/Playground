using playground.TreeNode;
using playground.UnitTest.Utils;

namespace playground.UnitTest.TreeNode;

public class WidthOfBinaryTreeTest
{
    [Theory]
    [InlineData("[1,3,2,5,3,null,9]", 4)]
    [InlineData("[1,3,2,5]", 2)]
    [InlineData("[1,1,1,1,1,1,1,null,null,null,1,null,null,null,null,2,2,2,2,2,2,2,null,2,null,null,2,null,2]", 8)]
    public void WidthOfBinaryTree(string str, int expect)
    {
        var node = str.ToTreeNode();
        var actual = WidthOfBinaryTreeClass.WidthOfBinaryTree(node);
        Assert.Equal(expect, actual);
    }
}
