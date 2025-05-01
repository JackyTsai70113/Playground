using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0606_Tree2strTest
{
    [Theory]
    [InlineData("[1,2,3,4]", "1(2(4))(3)")]
    [InlineData("[1,2,3,null,4]", "1(2()(4))(3)")]
    public void Tree2str(string root, string expected)
    {
        var actual = _0606_Tree2str.Tree2str(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
