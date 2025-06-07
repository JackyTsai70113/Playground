using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3170_ClearStarsTest
{
    [Theory]
    [InlineData("aaba*", "aab")]
    [InlineData("abc", "abc")]
    [InlineData("zzbz*", "zzz")]
    public void ClearStars(string s, string expected)
    {
        var actual = _3170_ClearStars.ClearStars(s);
        Assert.Equal(expected, actual);
    }
}
