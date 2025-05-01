using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0788_RotatedDigitsTest
{
    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 1)]
    [InlineData(10, 4)]
    [InlineData(61, 24)]
    [InlineData(69, 29)]
    [InlineData(650, 200)]
    public void RotatedDigits(int n, int expected)
    {
        var actual = _0788_RotatedDigits.RotatedDigits(n);
        Assert.Equal(expected, actual);
    }
}
