namespace playground.UnitTest.LeetCode._1000_1999;

public class _1249_MinRemoveToMakeValidTest
{
    [Theory]
    [InlineData("lee(t(c)o)de)", "lee(t(c)o)de")]
    [InlineData("a)b(c)d", "ab(c)d")]
    [InlineData("))((", "")]
    public void MinRemoveToMakeValid(string s, string expected)
    {
        var actual = _1249_MinRemoveToMakeValid.MinRemoveToMakeValid(s);
        Assert.Equal(expected, actual);
    }
}
