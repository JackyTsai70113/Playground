using playground.Strings;

namespace playground.UnitTest.Strings;

public class IsValidTest
{
    [Theory]
    [InlineData("(([]){})", true)]
    public void IsValid(string s, bool expected)
    {
        var actual = IsValidClass.IsValid(s);
        Assert.Equal(expected, actual);
    }
}
