using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0678_CheckValidStringTest
{
    [Theory]
    [InlineData(")", false)]
    [InlineData("()", true)]
    [InlineData("(*)", true)]
    [InlineData("(*))", true)]
    [InlineData("((", false)]
    [InlineData("(***)", true)]
    [InlineData("(((*****", true)]
    [InlineData("(((**", false)]
    public void CheckValidString(string s, bool expected)
    {
        var actual = _0678_CheckValidString.CheckValidString(s);
        Assert.Equal(expected, actual);
    }
}
