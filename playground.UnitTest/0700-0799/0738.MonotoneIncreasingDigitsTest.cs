namespace playground.UnitTest;

public class MonotoneIncreasingDigitsTest0738
{
    [Theory]
    [InlineData(10, 9)]
    [InlineData(1234, 1234)]
    [InlineData(332, 299)]
    [InlineData(2111, 1999)]
    [InlineData(1006, 999)]
    public void MonotoneIncreasingDigits(int n, int expected)
    {
        var actual = MonotoneIncreasingDigits0738.MonotoneIncreasingDigits(n);
        Assert.Equal(expected, actual);
    }
}
