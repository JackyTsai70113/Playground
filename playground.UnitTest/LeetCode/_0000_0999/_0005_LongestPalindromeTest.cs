using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0005_LongestPalindromeTest
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    public void LongestPalindrome(string s, string expected)
    {
        var actual = _0005_LongestPalindrome.LongestPalindrome(s);
        Assert.Equal(expected, actual);
    }
}
