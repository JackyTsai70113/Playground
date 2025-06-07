using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1062_LongestRepeatingSubstringTest
{
    [Theory]
    [InlineData("abcd", 0)]
    [InlineData("abbaba", 2)]
    [InlineData("aaaaaa", 5)]
    [InlineData("aabcaabdaab", 3)]
    public void LongestRepeatingSubstring(string s, int expected)
    {
        var actual = _1062_LongestRepeatingSubstring.LongestRepeatingSubstring(s);
        Assert.Equal(expected, actual);
    }
}
