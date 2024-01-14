namespace playground.UnitTest;

public class CloseStringsTest1657
{
    [Theory]
    [InlineData("abc", "bca", true)]
    [InlineData("a", "aa", false)]
    [InlineData("cabbba", "abbccc", true)]
    [InlineData("abc", "ccc", false)]
    [InlineData("abcc", "abdd", false)]
    public void CloseStrings(string word1, string word2, bool expected)
    {
        var actual = CloseStrings1657.CloseStrings(word1, word2);
        Assert.Equal(expected, actual);
    }
}
