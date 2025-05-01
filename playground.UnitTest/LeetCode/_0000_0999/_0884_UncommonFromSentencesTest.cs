using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0884_UncommonFromSentencesTest
{
    [Theory]
    [InlineData("apple apple", "banana", new string[] { "banana" })]
    [InlineData("this apple is sweet", "this apple is sour", new string[] { "sweet", "sour" })]
    public void UncommonFromSentences(string s1, string s2, string[] expected)
    {
        var actual = _0884_UncommonFromSentences.UncommonFromSentences(s1, s2);
        Assert.Equal(expected, actual);
    }
}
