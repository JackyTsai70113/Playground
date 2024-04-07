namespace playground.UnitTest;

public class MinRemoveToMakeValidTest1249
{
    [Theory]
    [InlineData("lee(t(c)o)de)", "lee(t(c)o)de")]
    [InlineData("a)b(c)d", "ab(c)d")]
    [InlineData("))((", "")]
    public void MinRemoveToMakeValid(string s, string expected)
    {
        var actual = MinRemoveToMakeValid1249.MinRemoveToMakeValid(s);
        Assert.Equal(expected, actual);
    }
}
