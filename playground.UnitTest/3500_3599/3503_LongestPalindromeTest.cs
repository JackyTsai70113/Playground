using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3503_LongestPalindromeTest
{
    [Theory]
    [InlineData("a", "a", 2)]
    [InlineData("abc", "dsf", 1)]
    [InlineData("b", "aaaa", 4)]
    [InlineData("abcde", "ecdba", 5)]
    [InlineData("n", "no", 2)]
    [InlineData("vn", "ln", 3)]
    [InlineData("hc", "jooh", 4)]
    [InlineData("jjh", "g", 2)]
    public void LongestPalindrome(string s, string t, int expected)
    {
        var actual = _3503_LongestPalindrome.LongestPalindrome(s, t);
        Assert.Equal(expected, actual);
    }
}
