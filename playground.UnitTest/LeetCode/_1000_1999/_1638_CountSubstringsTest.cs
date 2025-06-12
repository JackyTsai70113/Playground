using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1638_CountSubstringsTest
{
    [Theory]
    [InlineData("aba", "baba", 6)]
    [InlineData("ab", "aa", 3)]
    [InlineData("b", "c", 1)]
    public void CountSubstrings(string s, string t, int expected)
    {
        var actual = _1638_CountSubstrings.CountSubstrings(s, t);
        Assert.Equal(expected, actual);
    }
}
