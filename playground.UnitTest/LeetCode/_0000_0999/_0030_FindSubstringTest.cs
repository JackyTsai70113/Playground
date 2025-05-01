using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0030_FindSubstringTest
{
    [Theory]
    [InlineData("barfoothefoobarman", new string[] { "foo", "bar" }, "[0,9]")]
    [InlineData("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "word" }, "[]")]
    [InlineData("barfoofoobarthefoobarman", new string[] { "bar", "foo", "the" }, "[6,9,12]")]
    public void FindSubstring(string s, string[] words, string expected)
    {
        var actual = _0030_FindSubstring.FindSubstring(s, words);
        Assert.Equal(expected.ToArr(), actual);
    }
}
