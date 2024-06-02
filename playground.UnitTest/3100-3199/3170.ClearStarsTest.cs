namespace playground.UnitTest;

public class ClearStarsTest3170
{
    [Theory]
    [InlineData("aaba*", "aab")]
    [InlineData("abc", "abc")]
    [InlineData("zzbz*", "zzz")]
    public void ClearStars(string s, string expected)
    {
        var actual = ClearStars3170.ClearStars(s);
        Assert.Equal(expected, actual);
    }
}
