namespace playground.UnitTest;

public class StringHashTest3271
{
    [Theory]
    [InlineData("abcd", 2, "bf")]
    [InlineData("mxz", 3, "i")]
    public void StringHashTest(string s, int k, string expected)
    {
        var actual = StringHash3271.StringHash(s, k);
        Assert.Equal(expected, actual);
    }
}