using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0309_MaxProfitTest
{
    [Theory]
    [InlineData(new int[] { 1, 7, 3, 0, 4, 2 }, 10)]
    [InlineData(new int[] { 1, 2, 3, 0, 2 }, 3)]
    [InlineData(new int[] { 1 }, 0)]
    public void MaxProfitCoolDown(int[] prices, int expected)
    {
        var actual = _0309_MaxProfit.MaxProfit(prices);
        Assert.Equal(expected, actual);
    }
}
