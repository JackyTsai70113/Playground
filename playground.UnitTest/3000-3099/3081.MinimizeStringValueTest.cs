namespace playground.UnitTest;

public class MinimizeStringValueTest3081
{
    [Theory]
    [InlineData("???", "abc")]
    [InlineData("a?a?", "abac")]
    [InlineData("abcdefghijklmnopqrstuvwxy??", "abcdefghijklmnopqrstuvwxyaz")]
    public void MinimizeStringValue(string s, string expected)
    {
        var actual = MinimizeStringValue3081.MinimizeStringValue(s);
        Assert.Equal(expected, actual);
    }
}
