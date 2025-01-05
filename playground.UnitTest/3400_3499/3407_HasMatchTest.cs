using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3407_HasMatchTest
{
    [Theory]
    [InlineData("leetcode", "ee*e", true)]
    [InlineData("car", "c*v", false)]
    [InlineData("luck", "u*", true)]
    [InlineData("tokk", "t*t", false)]
    [InlineData("kvb", "k*v", true)]
    [InlineData("nrnrs", "*nn", false)]
    [InlineData("ckckkk", "*ck*kc", false)]
    public void MinStartingIndex(string s, string p, bool expected)
    {
        var actual = _3407_HasMatch.HasMatch(s, p);
        Assert.Equal(expected, actual);
    }
}
