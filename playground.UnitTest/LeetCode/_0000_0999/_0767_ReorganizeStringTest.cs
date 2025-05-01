using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0767_ReorganizeStringTest
{
    [Theory]
    [InlineData("aab", "aba")]
    [InlineData("aaab", "")]
    [InlineData("eqmeyggvp", "egegvqpmy")]
    [InlineData("aabbcc", "acbcba")]
    [InlineData("kkkkzrkatkwpkkkktrq", "ktkrkzktkrkwkqkpkak")]
    public void ReorganizeString(string s, string expected)
    {
        var actual = _0767_ReorganizeString.ReorganizeString(s);
        Assert.Equal(expected, actual);
    }
}
