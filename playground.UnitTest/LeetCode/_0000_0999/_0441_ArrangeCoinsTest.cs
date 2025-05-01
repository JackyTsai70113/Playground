using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0441_ArrangeCoinsTest
{
    [Theory]
    [InlineData(5, 2)]
    [InlineData(8, 3)]
    [InlineData(1804289383, 60070)]
    public void ArrangeCoins(int n, int expected)
    {
        var actual = _0441_ArrangeCoins.ArrangeCoins(n);
        Assert.Equal(expected, actual);
    }
}
