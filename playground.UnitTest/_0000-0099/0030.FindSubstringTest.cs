namespace playground.UnitTest;

public class FindSubstringTest0030
{
    [Theory]
    [InlineData("barfoothefoobarman", new string[] { "foo", "bar" }, "[0,9]")]
    [InlineData("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "word" }, "[]")]
    [InlineData("barfoofoobarthefoobarman", new string[] { "bar", "foo", "the" }, "[6,9,12]")]
    public void FindSubstring(string s, string[] words, string expected)
    {
        var actual = FindSubstring0030.FindSubstring(s, words);
        Assert.Equal(expected.ToArr(), actual);
    }
}
