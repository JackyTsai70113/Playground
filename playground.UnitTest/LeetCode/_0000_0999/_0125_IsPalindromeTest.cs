using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0125_IsPalindromeTest
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    public void IsPalindrome(string s, bool expected)
    {
        var actual = _0125_IsPalindrome.IsPalindrome(s);
        Assert.Equal(expected, actual);
    }
}
