namespace playground.UnitTest;

public class RomanToIntTest_0013
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("D", 500)]
    [InlineData("CD", 400)]
    public void RomanToInt(string s, int expected)
    {
        var actual = RomanToInt_0013.RomanToInt(s);
        Assert.Equal(expected, actual);
    }
}
