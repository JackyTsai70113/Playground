namespace playground.UnitTest;

public class WordBreakTest0139
{
    [Theory]
    [InlineData("leetcode", new string[] { "leet", "code" }, true)]
    [InlineData("applepenapple", new string[] { "apple", "pen" }, true)]
    [InlineData("catsandog", new string[] { "cats", "dog", "sand", "and", "cat" }, false)]
    [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", new string[] { "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa" }, false)]
    public void WordBreak(string s, IList<string> wordDict, bool expected)
    {
        var actual = WordBreak0139.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }
}
