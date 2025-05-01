using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0592_FractionAdditionTest
{
    [Theory]
    [InlineData("-1/2+1/2", "0/1")]
    [InlineData("-1/2+1/2+1/3", "1/3")]
    [InlineData("1/4-1/4", "0/1")]
    [InlineData("5/8-1/8", "1/2")]
    [InlineData("1/3-1/2", "-1/6")]
    [InlineData("-1/4-4/5-1/4", "-13/10")]
    public void FractionAddition(string expression, string expected)
    {
        var actual = _0592_FractionAddition.FractionAddition(expression);
        Assert.Equal(expected, actual);
    }
}
