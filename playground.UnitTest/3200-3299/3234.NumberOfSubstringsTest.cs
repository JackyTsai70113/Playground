namespace playground.UnitTest;

public class NumberOfSubstringsTest3234
{
    [Theory]
    [InlineData("11", 3)]
    [InlineData("101", 5)]
    [InlineData("00011", 5)]
    [InlineData("101101", 16)]
    public void NumberOfSubstrings(string s, int expected)
    {
        var actual = new NumberOfSubstrings3234().NumberOfSubstrings(s);
        Assert.Equal(expected, actual);
    }
}
