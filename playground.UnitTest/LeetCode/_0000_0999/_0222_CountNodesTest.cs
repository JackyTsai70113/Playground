using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0222_CountNodesTest
{
    [Theory]
    [InlineData("[1,2,3,4,5,6]", 6)]
    [InlineData("[1]", 1)]
    [InlineData("[]", 0)]
    public void CountNodes(string root, int expected)
    {
        var actual = _0222_CountNodes.CountNodes(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
