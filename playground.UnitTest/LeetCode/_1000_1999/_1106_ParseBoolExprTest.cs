using playground._1100_1199;

namespace playground.UnitTest._1100_1199;

public class _1106_ParseBoolExprTest
{
    [Theory]
    [InlineData("&(|(f))", false)]
    [InlineData("|(f,f,f,t)", true)]
    [InlineData("&(f,!(f),!(t),t)", false)]
    [InlineData("!(&(t,t))", false)]
    public void ParseBoolExpr(string s, bool expected)
    {
        var actual = _1106_ParseBoolExpr_cs.ParseBoolExpr(s);
        Assert.Equal(expected, actual);
    }
}
