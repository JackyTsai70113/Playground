namespace playground.UnitTest.LeetCode._3000_3999;

public class _3234_NumberOfSubstringsTest
{
    [Theory]
    [InlineData("11", 3)]
    [InlineData("101", 5)]
    [InlineData("00011", 5)]
    [InlineData("101101", 16)]
    public void NumberOfSubstrings(string s, int expected)
    {
        var actual = new _3234_NumberOfSubstrings().NumberOfSubstrings(s);
        Assert.Equal(expected, actual);
    }
}
