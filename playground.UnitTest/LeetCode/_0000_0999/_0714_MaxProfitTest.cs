using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0714_MaxProfitTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 2, 8, 4, 9 }, 2, 8)]
    [InlineData(new int[] { 1, 3, 7, 5, 10, 3 }, 3, 6)]
    public void MaxProfitWithFee(int[] prices, int fee, int expected)
    {
        var actual = _0714_MaxProfit.MaxProfit(prices, fee);
        Assert.Equal(expected, actual);
    }
}
