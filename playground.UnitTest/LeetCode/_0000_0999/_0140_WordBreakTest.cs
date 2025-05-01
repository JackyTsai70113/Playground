using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0140_WordBreakTest
{
    [Theory]
    [InlineData("catsanddog", new string[] { "cat", "cats", "and", "sand", "dog" }, new string[] { "cat sand dog", "cats and dog" })]
    [InlineData("pineapplepenapple", new string[] { "apple", "pen", "applepen", "pine", "pineapple" }, new string[] { "pine apple pen apple", "pine applepen apple", "pineapple pen apple" })]
    [InlineData("catsandog", new string[] { "cat", "cats", "and", "sand", "dog" }, new string[] { })]
    public void WordBreak(string s, IList<string> wordDict, IList<string> expected)
    {
        var actual = _0140_WordBreak.WordBreak(s, wordDict);
        Assert.Equal(expected, actual);
    }
}
