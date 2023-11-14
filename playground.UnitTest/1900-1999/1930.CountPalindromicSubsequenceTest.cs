namespace playground.UnitTest;

public class CountPalindromicSubsequenceTest
{
    [Theory]
    [InlineData("aabca", 3)]
    [InlineData("adc", 0)]
    [InlineData("bbcbaba", 4)]
    public void CountPalindromicSubsequence(string s, int expected)
    {
        var actual = CountPalindromicSubsequence_1930.CountPalindromicSubsequence(s);
        Assert.Equal(expected, actual);
    }
}
