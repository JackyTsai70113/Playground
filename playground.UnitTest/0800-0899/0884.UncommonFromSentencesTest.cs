namespace playground.UnitTest;

public class UncommonFromSentencesTest0884
{
    [Theory]
    [InlineData("apple apple", "banana", new string[] { "banana" })]
    [InlineData("this apple is sweet", "this apple is sour", new string[] { "sweet", "sour" })]
    public void UncommonFromSentences(string s1, string s2, string[] expected)
    {
        var actual = UncommonFromSentences0884.UncommonFromSentences(s1, s2);
        Assert.Equal(expected, actual);
    }
}
