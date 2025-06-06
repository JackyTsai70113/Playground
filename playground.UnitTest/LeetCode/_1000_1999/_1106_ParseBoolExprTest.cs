using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1106_ParseBoolExprTest
{
    [Theory]
    [InlineData("&(|(f))", false)]
    [InlineData("|(f,f,f,t)", true)]
    [InlineData("&(f,!(f),!(t),t)", false)]
    [InlineData("!(&(t,t))", false)]
    public void ParseBoolExpr(string s, bool expected)
    {
        var actual = _1106_ParseBoolExpr.ParseBoolExpr(s);
        Assert.Equal(expected, actual);
    }
}
