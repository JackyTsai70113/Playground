using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0151_ReverseWordsTest
{
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void ReverseWords(string s, string expected)
    {
        var actual = _0151_ReverseWords.ReverseWords(s);
        Assert.Equal(expected, actual);
    }
}
