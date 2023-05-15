using playground.HashTables;

namespace playground.UnitTest.HashTables;

public class UncommonFromSentencesTest
{
    [Theory]
    [InlineData("apple apple", "banana", "[banana]")]
    [InlineData("this apple is sweet", "this apple is sour", "[sweet,sour]")]
    public void UncommonFromSentences(string a, string b, string expected)
    {
        var actual = UncommonFromSentencesClass.UncommonFromSentences(a, b);
        Assert.Equal(expected.ToArr<string>(), actual);
    }
}
