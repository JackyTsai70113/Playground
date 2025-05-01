using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0139_WordBreakTest
{
    [Theory]
    [InlineData("leetcode", new string[] { "leet", "code" }, true)]
    [InlineData("applepenapple", new string[] { "apple", "pen" }, true)]
    [InlineData("catsandog", new string[] { "cats", "dog", "sand", "and", "cat" }, false)]
    [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", new string[] { "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa" }, false)]
    public void WordBreak(string s, IList<string> wordDict, bool expected)
    {
        var actual = _0139_WordBreak.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }
}
