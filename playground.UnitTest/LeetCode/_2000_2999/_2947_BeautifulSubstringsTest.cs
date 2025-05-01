using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2947_BeautifulSubstringsTest
{
    [Theory]
    [InlineData("baeyh", 2, 2)]
    [InlineData("abba", 1, 3)]
    [InlineData("bcdf", 1, 0)]
    public void BeautifulSubstrings(string s, int k, int expected)
    {
        var actual = _2947_BeautifulSubstrings.BeautifulSubstrings(s, k);
        Assert.Equal(expected, actual);
    }
}
