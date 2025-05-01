using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0564_NearestPalindromicTest
{
    [Theory]
    [InlineData("123", "121")]
    [InlineData("1", "0")]
    [InlineData("1234", "1221")]
    [InlineData("4321", "4334")]
    [InlineData("999", "1001")]
    [InlineData("1000", "999")]
    [InlineData("1001", "999")]
    [InlineData("1837722381", "1837667381")]
    public void NearestPalindromic(string n, string expected)
    {
        var actual = _0564_NearestPalindromic.NearestPalindromic(n);
        Assert.Equal(expected, actual);
    }
}
