using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0003_LengthOfLongestSubstringTest
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData(" ", 1)]
    public void LengthOfLongestSubstring(string s, int expected)
    {
        var actual = _0003_LengthOfLongestSubstring.LengthOfLongestSubstring(s);
        Assert.Equal(expected, actual);
    }
}
