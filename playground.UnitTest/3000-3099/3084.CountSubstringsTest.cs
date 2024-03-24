namespace playground.UnitTest;

public class CountSubstringsTest3084
{
    [Theory]
    [InlineData("abada", 'a', 6)]
    [InlineData("zzz", 'z', 6)]
    public void CountSubstrings(string s, char c, long expected)
    {
        var actual = CountSubstrings3084.CountSubstrings(s, c);
        Assert.Equal(expected, actual);
    }
}
