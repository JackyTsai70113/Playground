namespace playground.UnitTest;

public class DiameterOfBinaryTreeTest0543
{
    [Theory]
    [InlineData("[1,2,3,4,5]", 3)]
    [InlineData("[1,2]", 1)]
    public void DiameterOfBinaryTree(string nums, int expected)
    {
        var actual = DiameterOfBinaryTree0543.DiameterOfBinaryTree(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
