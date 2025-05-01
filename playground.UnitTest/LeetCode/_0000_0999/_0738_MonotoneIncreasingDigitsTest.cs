using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0738_MonotoneIncreasingDigitsTest
{
    [Theory]
    [InlineData(10, 9)]
    [InlineData(1234, 1234)]
    [InlineData(332, 299)]
    [InlineData(2111, 1999)]
    [InlineData(1006, 999)]
    public void MonotoneIncreasingDigits(int n, int expected)
    {
        var actual = _0738_MonotoneIncreasingDigits.MonotoneIncreasingDigits(n);
        Assert.Equal(expected, actual);
    }
}
