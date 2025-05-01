using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0050_MyPowTest
{
    [Theory]
    [InlineData(0, 10, 0)]
    [InlineData(1, 10, 1)]
    [InlineData(10000, 0, 1)]
    [InlineData(2.00, 10, 1024.00000)]
    [InlineData(2.1, 3, 9.261)]
    [InlineData(2.00, -2, 0.2500000)]
    [InlineData(34.00515, -3, 0.00003)]
    public void MinimumDistance(double x, int n, double expected)
    {
        var actual = _0050_MyPow.MyPow(x, n);
        Assert.True(Math.Abs(actual - expected) < 0.00001);
    }
}
