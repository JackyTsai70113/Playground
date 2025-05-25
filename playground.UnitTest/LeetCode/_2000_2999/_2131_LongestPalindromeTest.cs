using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2131_LongestPalindromeTest
{
    [Theory]
    [InlineData(new string[] { "lc", "cl", "gg" }, 6)]
    [InlineData(new string[] { "ab", "ty", "yt", "lc", "cl", "ab" }, 8)]
    [InlineData(new string[] { "cc", "ll", "xx" }, 2)]
    [InlineData(new string[] { "qo", "fo", "fq", "qf", "fo", "ff", "qq", "qf", "of", "of", "oo", "of", "of", "qf", "qf", "of" }, 14)]
    [InlineData(new string[] { "fo", "of" }, 4)]
    public void LongestPalindrome(string[] words, int expected)
    {
        var actual = _2131_LongestPalindrome.LongestPalindrome(words);
        Assert.Equal(expected, actual);
    }
}
