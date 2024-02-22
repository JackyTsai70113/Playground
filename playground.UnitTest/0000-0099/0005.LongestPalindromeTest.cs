namespace playground.UnitTest;

public class LongestPalindromeTest0005
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    public void LongestPalindrome(string s, string expected)
    {
        var actual = LongestPalindrome0005.LongestPalindrome(s);
        Assert.Equal(expected, actual);
    }
}
