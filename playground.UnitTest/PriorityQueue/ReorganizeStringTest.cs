using playground.PriorityQueues;

namespace playground.UnitTest.PriorityQueue;

public class ReorganizeStringTest
{
    [Theory]
    [InlineData("aab", "aba")]
    [InlineData("aaab", "")]
    [InlineData("eqmeyggvp", "egegvqpmy")]
    [InlineData("aabbcc", "acbcba")]
    [InlineData("kkkkzrkatkwpkkkktrq", "ktkrktkrkakwkqkpkzk")]
    public void ReorganizeString(string s, string expected)
    {
        var actual = ReorganizeStringClass.ReorganizeString(s);
        Assert.Equal(expected, actual);
    }
}
