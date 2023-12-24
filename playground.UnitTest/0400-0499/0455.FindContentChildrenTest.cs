namespace playground.UnitTest;

public class FindContentChildrenTest0455
{
    [Theory]
    [InlineData("[1,2,3]", "[1,1]", 1)]
    [InlineData("[1,2]", "[1,2,3]", 2)]
    public void FindContentChildren(string g, string s, int expected)
    {
        var actual = FindContentChildren0455.FindContentChildren(g.ToArr(), s.ToArr());
        Assert.Equal(expected, actual);
    }
}
