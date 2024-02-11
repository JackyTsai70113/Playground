namespace playground.UnitTest;

public class CountSubstringsTest0647
{
    [Theory]
    [InlineData("abc", 3)]
    [InlineData("aaa", 6)]
    public void CountSubstrings(string s, int expected)
    {
        var actual = CountSubstrings0647.CountSubstrings(s);
        Assert.Equal(expected, actual);
    }
}
