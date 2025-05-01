using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0455_FindContentChildrenTest
{
    [Theory]
    [InlineData("[1,2,3]", "[1,1]", 1)]
    [InlineData("[1,2]", "[1,2,3]", 2)]
    public void FindContentChildren(string g, string s, int expected)
    {
        var actual = _0455_FindContentChildren.FindContentChildren(g.ToArr(), s.ToArr());
        Assert.Equal(expected, actual);
    }
}
