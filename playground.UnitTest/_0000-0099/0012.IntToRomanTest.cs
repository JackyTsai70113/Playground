namespace playground.UnitTest;

public class IntToRomanTest_0012
{
    [Theory]
    [InlineData(43, "XLIII")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    [InlineData(660, "DCLX")]
    [InlineData(499, "CDXCIX")]
    public void IntToRoman(int num, string expected)
    {
        var actual = IntToRoman_0012.IntToRoman(num);
        Assert.Equal(expected, actual);
    }
}
