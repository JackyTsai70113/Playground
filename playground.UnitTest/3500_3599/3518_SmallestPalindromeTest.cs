using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3518_SmallestPalindromeTest
{
    [Theory]
    [InlineData("abba", 2, "baab")]
    [InlineData("aa", 2, "")]
    [InlineData("bacab", 1, "abcba")]
    [InlineData("o", 1, "o")]
    public void SmallestPalindrome(string s, int k, string expected)
    {
        var actual = _3518_SmallestPalindrome.SmallestPalindrome(s, k);
        Assert.Equal(expected, actual);
    }
}
