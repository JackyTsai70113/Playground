namespace playground.UnitTest;

public class WidthOfBinaryTreeTest0662
{
    [Theory]
    [InlineData("[1,3,2,5,3,null,9]", 4)]
    [InlineData("[1,3,2,5]", 2)]
    [InlineData("[1,1,1,1,1,1,1,null,null,null,1,null,null,null,null,2,2,2,2,2,2,2,null,2,null,null,2,null,2]", 8)]
    public void WidthOfBinaryTree2(string root, int expected)
    {
        var actual = WidthOfBinaryTree0662.WidthOfBinaryTree(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
