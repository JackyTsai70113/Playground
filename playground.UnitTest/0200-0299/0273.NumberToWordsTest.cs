namespace playground.UnitTest;

public class NumberToWordsTest0273
{
    [Theory]
    [InlineData(123, "One Hundred Twenty Three")]
    [InlineData(12345, "Twelve Thousand Three Hundred Forty Five")]
    [InlineData(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
    [InlineData(1234567891, "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninty One")]
    public void NumberToWords(int num, string expected)
    {
        var actual = new NumberToWords0273().NumberToWords(num);
        Assert.Equal(expected, actual);
    }
}
