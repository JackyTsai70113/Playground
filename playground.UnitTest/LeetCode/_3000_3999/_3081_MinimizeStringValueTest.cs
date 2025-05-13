namespace playground.UnitTest.LeetCode._3000_3999;

public class _3081_MinimizeStringValueTest
{
    [Theory]
    [InlineData("???", "abc")]
    [InlineData("a?a?", "abac")]
    [InlineData("abcdefghijklmnopqrstuvwxy??", "abcdefghijklmnopqrstuvwxyaz")]
    public void MinimizeStringValue(string s, string expected)
    {
        var actual = _3081_MinimizeStringValue.MinimizeStringValue(s);
        Assert.Equal(expected, actual);
    }
}
