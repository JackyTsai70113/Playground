using playground.DynamicProgramming;

namespace playground.UnitTest.Strings;

public class MinimumBeautifulSubstringsTest
{
    [Theory]
    [InlineData("101101101111001", 5)]
    [InlineData("1011", 2)]
    [InlineData("111", 3)]
    [InlineData("0", -1)]
    public void MinimumBeautifulSubstrings(string s, int expected)
    {
        var actual = MinimumBeautifulSubstringsClass.MinimumBeautifulSubstrings(s);
        Assert.Equal(expected, actual);
    }
}
