namespace playground.UnitTest;

public class _3084_CountSubstringsTest
{
    [Theory]
    [InlineData("abada", 'a', 6)]
    [InlineData("zzz", 'z', 6)]
    public void CountSubstrings(string s, char c, long expected)
    {
        var actual = _3084_CountSubstrings.CountSubstrings(s, c);
        Assert.Equal(expected, actual);
    }
}
