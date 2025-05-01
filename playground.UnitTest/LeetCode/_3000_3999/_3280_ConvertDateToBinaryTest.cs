namespace playground.UnitTest;

public class _3280_ConvertDateToBinaryTest
{
    [Theory]
    [InlineData("2080-02-29", "100000100000-10-11101")]
    [InlineData("1900-01-01", "11101101100-1-1")]
    public void ConvertDateToBinary(string date, string expected)
    {
        var actual = _3280_ConvertDateToBinary.ConvertDateToBinary(date);
        Assert.Equal(expected, actual);
    }
}
