using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0273_NumberToWordsTest
{
    [Theory]
    [InlineData(0, "Zero")]
    [InlineData(123, "One Hundred Twenty Three")]
    [InlineData(1009, "One Thousand Nine")]
    [InlineData(1092, "One Thousand Ninety Two")]
    [InlineData(12345, "Twelve Thousand Three Hundred Forty Five")]
    [InlineData(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
    [InlineData(100000000, "One Hundred Million")]
    [InlineData(1234567891, "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One")]
    public void NumberToWords(int num, string expected)
    {
        var actual = new _0273_NumberToWords().NumberToWords(num);
        Assert.Equal(expected, actual);
    }
}
