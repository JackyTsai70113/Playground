using playground.Strings;

namespace playground.UnitTest.Strings;

public class IsNumberTest
{
    [Theory]
    [InlineData("2", true)]
    [InlineData("0089", true)]
    [InlineData("-0.1", true)]
    [InlineData("+3.14", true)]
    [InlineData("4.", true)]
    [InlineData("-.9", true)]
    [InlineData("2e10", true)]
    [InlineData("-90E3", true)]
    [InlineData("3e+7", true)]
    [InlineData("+6e-1", true)]
    [InlineData("53.5e93", true)]
    [InlineData("-123.456e789", true)]
    [InlineData("0", true)]
    [InlineData("abc", false)]
    [InlineData("1a", false)]
    [InlineData("1e", false)]
    [InlineData("e3", false)]
    [InlineData("99e2.5", false)]
    [InlineData("--6", false)]
    [InlineData("-+3", false)]
    [InlineData("95a54e53", false)]
    [InlineData("e", false)]
    [InlineData(".", false)]
    [InlineData("0..", false)]
    public void IsNumber(string s, bool expected)
    {
        var actual = IsNumberClass.IsNumber(s);
        Assert.Equal(expected, actual);
    }
}
