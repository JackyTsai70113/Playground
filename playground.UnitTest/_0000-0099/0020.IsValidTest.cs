namespace playground.UnitTest;

public class IsValidTest_0020
{
    [Theory]
    [InlineData("(([]){})", true)]
    [InlineData(")", false)]
    [InlineData("]", false)]
    [InlineData("}", false)]
    [InlineData("[)", false)]
    [InlineData("(]", false)]
    [InlineData("(}", false)]
    public void IsValid(string s, bool expected)
    {
        var actual = IsValid_0020.IsValid(s);
        Assert.Equal(expected, actual);
    }
}
