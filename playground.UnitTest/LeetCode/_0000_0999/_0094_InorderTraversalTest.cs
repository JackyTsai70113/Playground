using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0094_InorderTraversalTest
{
    [Theory]
    [InlineData("[1,null,2,3]", "[1,3,2]")]
    [InlineData("[1]", "[1]")]
    [InlineData("[]", "[]")]
    public void InorderTraversal(string root, string expected)
    {
        var actual = _0094_InorderTraversal.InorderTraversal(root.ToTreeNode());
        Assert.Equal(expected.ToArr(), actual);
    }
}
