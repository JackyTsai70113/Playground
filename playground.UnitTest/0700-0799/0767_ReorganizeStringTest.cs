using playground._0700_0799;

namespace playground.UnitTest._0700_0799;

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
