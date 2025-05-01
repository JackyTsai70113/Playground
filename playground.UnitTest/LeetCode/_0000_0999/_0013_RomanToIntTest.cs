using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0013_RomanToIntTest
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("D", 500)]
    [InlineData("CD", 400)]
    public void RomanToInt(string s, int expected)
    {
        var actual = _0013_RomanToInt.RomanToInt(s);
        Assert.Equal(expected, actual);
    }
}
