namespace playground.UnitTest;

public class _1367_IsSubPathTest
{
    [Theory]
    [InlineData("[4,2,8]", "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", true)]
    [InlineData("[1,4,2,6]", "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", true)]
    [InlineData("[1,4,6,2,8]", "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", false)]
    public void IsSubPath(string head, string root, bool expected)
    {
        var actual = _1367_IsSubPath.IsSubPath(head.ToListNode(), root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
