using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0100_IsSameTreeTest
{
    [Theory]
    [InlineData("[1,2,3]", "[1,2,3]", true)]
    [InlineData("[1,2]", "[1,null,2]", false)]
    [InlineData("[1,null,2]", "[1,2]", false)]
    [InlineData("[1,2,1]", "[1,1,2]", false)]
    public void IsSameTree(string p, string q, bool expected)
    {
        var actual = _0100_IsSameTree.IsSameTree(p.ToTreeNode(), q.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
