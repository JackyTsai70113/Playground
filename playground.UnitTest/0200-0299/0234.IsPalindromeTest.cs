namespace playground.UnitTest;

public class IsPalindromeTest0234
{
    [Theory]
    [InlineData("[1,0,1]", true)]
    [InlineData("[1,2,2,1]", true)]
    [InlineData("[1,2]", false)]
    public void IsPalindrome(string list1, bool expected)
    {
        var actual = IsPalindrome0234.IsPalindrome(list1.ToListNode());
        Assert.Equal(expected, actual);
    }
}
