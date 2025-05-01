using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0012_IntToRomanTest
{
    [Theory]
    [InlineData(43, "XLIII")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    [InlineData(660, "DCLX")]
    [InlineData(499, "CDXCIX")]
    public void IntToRoman(int num, string expected)
    {
        var actual = _0012_IntToRoman.IntToRoman(num);
        Assert.Equal(expected, actual);
    }
}
