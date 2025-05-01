using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0234_IsPalindromeTest
{
    [Theory]
    [InlineData("[1,0,0]", false)]
    [InlineData("[1,0,1]", true)]
    [InlineData("[1,2,2,1]", true)]
    [InlineData("[1,2]", false)]
    public void IsPalindrome(string list1, bool expected)
    {
        var actual = _0234_IsPalindrome.IsPalindrome(list1.ToListNode());
        Assert.Equal(expected, actual);
    }
}
