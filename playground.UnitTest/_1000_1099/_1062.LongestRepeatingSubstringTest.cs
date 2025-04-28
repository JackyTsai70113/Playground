namespace playground.UnitTest;

public class LongestRepeatingSubstringTest1062
{
    [Theory]
    [InlineData("abcd", 0)]
    [InlineData("abbaba", 2)]
    [InlineData("aaaaaa", 5)]
    [InlineData("aabcaabdaab", 3)]
    public void LongestRepeatingSubstring(string s, int expected)
    {
        var actual = LongestRepeatingSubstring1062.LongestRepeatingSubstring(s);
        Assert.Equal(expected, actual);
    }
}
