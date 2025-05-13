using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3518_SmallestPalindromeTest
{
    [Theory]
    [InlineData("abba", 1, "abba")]
    [InlineData("abba", 2, "baab")]
    [InlineData("abba", 5, "")]
    [InlineData("aa", 2, "")]
    [InlineData("bacab", 1, "abcba")]
    [InlineData("xxnfnxx", 3, "xxnfnxx")]
    [InlineData("ycnypoidimbrvasctjkkwwkkjtcsavrbmidiopyncy", 32993, "abccdiijkkmnpwovytyrssrytyvowpnmkkjiidccba")]
    [InlineData("o", 1, "o")]
    [InlineData("o", 5, "")]
    public void SmallestPalindrome(string s, int k, string expected)
    {
        var actual = new _3518_SmallestPalindrome().SmallestPalindrome(s, k);
        Assert.Equal(expected, actual);
    }
}
