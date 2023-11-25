namespace playground.UnitTest;

public class ReverseWordsTest_0151
{
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void ReverseWords(string s, string expected)
    {
        var actual = ReverseWords_0151.ReverseWords(s);
        Assert.Equal(expected, actual);
    }
}
