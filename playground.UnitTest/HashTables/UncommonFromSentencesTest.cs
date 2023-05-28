using playground.HashTables;

namespace playground.UnitTest.HashTables;

public class UncommonFromSentencesTest
{
    [Theory]
    [InlineData("apple apple", "banana", new string[] { "banana" })]
    [InlineData("this apple is sweet", "this apple is sour", new string[] { "sweet", "sour" })]
    public void UncommonFromSentences(string s1, string s2, string[] expected)
    {
        var actual = UncommonFromSentencesClass.UncommonFromSentences(s1, s2);
        Assert.Equal(expected, actual);
    }
}
