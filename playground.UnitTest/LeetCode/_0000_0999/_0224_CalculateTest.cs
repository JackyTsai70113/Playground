using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0224_CalculateTest
{
    [Theory]
    [InlineData("1 + 1", 2)]
    [InlineData(" 2-1 + 2 ", 3)]
    [InlineData("(1+(4+5+2)-3)+(6+8)", 23)]
    [InlineData("(1-(4+5+2)-3)-(6+8)", -27)]
    [InlineData("1 + 12", 13)]
    public void Calculate(string s, int expected)
    {
        var actual = _0224_Calculate.Calculate(s);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("1 + 1", 2)]
    [InlineData(" 2-1 + 2 ", 3)]
    [InlineData("(1+(4+5+2)-3)+(6+8)", 23)]
    [InlineData("(1-(4+5+2)-3)-(6+8)", -27)]
    [InlineData("1 + 12", 13)]
    public void Calculate2(string s, int expected)
    {
        var actual = _0224_Calculate.Calculate2(s);
        Assert.Equal(expected, actual);
    }
}
