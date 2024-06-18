namespace playground.UnitTest;

public class IsPalindromeTest0125
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    public void IsPalindrome(string s, bool expected)
    {
        var actual = IsPalindrome0125.IsPalindrome(s);
        Assert.Equal(expected, actual);
    }
}
