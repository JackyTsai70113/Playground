namespace playground.UnitTest;

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
