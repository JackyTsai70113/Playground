using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0543_DiameterOfBinaryTreeTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", 3)]
    [InlineData("[1,2]", 1)]
    public void DiameterOfBinaryTree(string nums, int expected)
    {
        var actual = _0543_DiameterOfBinaryTree.DiameterOfBinaryTree(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
