using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0122_MaxProfitTest
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfit(int[] prices, int expected)
    {
        var actual = _0122_MaxProfit.MaxProfit(prices);
        Assert.Equal(expected, actual);
    }
}
