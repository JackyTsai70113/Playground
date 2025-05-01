using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0104_MaxDepthTest
{
    [Theory]
    [InlineData("[3,9,20,null,null,15,7]", 3)]
    [InlineData("[1,null,2]", 2)]
    public void MaxDepth(string root, int expected)
    {
        var actual = _0104_MaxDepth.MaxDepth(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
