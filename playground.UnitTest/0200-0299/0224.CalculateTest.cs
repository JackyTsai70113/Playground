namespace playground.UnitTest;

public class CalculateTest_0224
{
    [Theory]
    [InlineData("1 + 1", 2)]
    [InlineData(" 2-1 + 2 ", 3)]
    [InlineData("(1+(4+5+2)-3)+(6+8)", 23)]
    [InlineData("(1-(4+5+2)-3)-(6+8)", -27)]
    [InlineData("1 + 12", 13)]
    public void Calculate(string s, int expected)
    {
        var actual = Calculate_0224.Calculate(s);
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
        var actual = Calculate_0224.Calculate2(s);
        Assert.Equal(expected, actual);
    }
}
