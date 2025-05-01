using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2147_NumberOfWaysTest
{
    [Theory]
    [InlineData("SSPPSPS", 3)]
    [InlineData("PPSPSP", 1)]
    [InlineData("S", 0)]
    [InlineData("P", 0)]
    public void NumberOfWays(string s, int expected)
    {
        var actual = _2147_NumberOfWays.NumberOfWays(s);
        Assert.Equal(expected, actual);
    }
}
