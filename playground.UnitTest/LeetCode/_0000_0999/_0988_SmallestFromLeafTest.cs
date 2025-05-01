using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0988_SmallestFromLeafTest
{
    [Theory]
    [InlineData("[0,1,2,3,4,3,4]", "dba")]
    [InlineData("[25,1,3,1,3,0,2]", "adz")]
    [InlineData("[2,2,1,null,1,0,null,0]", "abc")]
    [InlineData("[0,1,0,3,4]", "aa")]
    [InlineData("[3,9,20,null,null,15,7]", "hud")]
    [InlineData("[4,0,1,1]", "bae")]
    [InlineData("[0,null,1]", "ba")]
    [InlineData("[25,1,null,0,0,1,null,null,null,0]", "ababz")]
    public void SmallestFromLeaf(string root, string expected)
    {
        var actual = _0988_SmallestFromLeaf.SmallestFromLeaf(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
