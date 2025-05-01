using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0647_CountSubstringsTest
{
    [Theory]
    [InlineData("abc", 3)]
    [InlineData("aaa", 6)]
    public void CountSubstrings(string s, int expected)
    {
        var actual = _0647_CountSubstrings.CountSubstrings(s);
        Assert.Equal(expected, actual);
    }
}
