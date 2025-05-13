using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1208_EqualSubstringTest
{
    [Theory]
    [InlineData("abcd", "bcdf", 3, 3)]
    [InlineData("abcd", "cdef", 3, 1)]
    [InlineData("abcd", "acde", 0, 1)]
    [InlineData("krrgw", "zjxss", 19, 2)]
    public void EqualSubstring(string s, string t, int maxCost, int expected)
    {
        var actual = _1208_EqualSubstring.EqualSubstring(s, t, maxCost);
        Assert.Equal(expected, actual);
    }
}
