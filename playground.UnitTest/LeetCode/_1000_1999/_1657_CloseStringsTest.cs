namespace playground.UnitTest;

public class _1657_CloseStringsTest
{
    [Theory]
    [InlineData("abc", "bca", true)]
    [InlineData("a", "aa", false)]
    [InlineData("cabbba", "abbccc", true)]
    [InlineData("abc", "ccc", false)]
    [InlineData("abcc", "abdd", false)]
    public void CloseStrings(string word1, string word2, bool expected)
    {
        var actual = _1657_CloseStrings.CloseStrings(word1, word2);
        Assert.Equal(expected, actual);
    }
}
