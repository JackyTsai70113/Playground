namespace playground.UnitTest;

public class _1291_SequentialDigitsTest
{
    [Theory]
    [InlineData(100, 300, "[123,234]")]
    [InlineData(1000, 13000, "[1234,2345,3456,4567,5678,6789,12345]")]
    [InlineData(10, 1000000000, "[12,23,34,45,56,67,78,89,123,234,345,456,567,678,789,1234,2345,3456,4567,5678,6789,12345,23456,34567,45678,56789,123456,234567,345678,456789,1234567,2345678,3456789,12345678,23456789,123456789]")]
    public void SequentialDigits(int low, int high, string expected)
    {
        var actual = _1291_SequentialDigits.SequentialDigits(low, high);
        Assert.Equal(expected.ToArr(), actual);
    }
}
