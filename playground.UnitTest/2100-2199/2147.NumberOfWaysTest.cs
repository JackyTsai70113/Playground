namespace playground.UnitTest;

public class NumberOfWaysTest
{
    [Theory]
    [InlineData("SSPPSPS", 3)]
    [InlineData("PPSPSP", 1)]
    [InlineData("S", 0)]
    [InlineData("P", 0)]
    public void NumberOfWays(string s, int expected)
    {
        var actual = NumberOfWays_2147.NumberOfWays(s);
        Assert.Equal(expected, actual);
    }
}
