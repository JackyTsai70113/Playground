namespace playground.UnitTest;

public class _3271_StringHashTest
{
    [Theory]
    [InlineData("abcd", 2, "bf")]
    [InlineData("mxz", 3, "i")]
    public void StringHashTest(string s, int k, string expected)
    {
        var actual = _3271_StringHash.StringHash(s, k);
        Assert.Equal(expected, actual);
    }
}