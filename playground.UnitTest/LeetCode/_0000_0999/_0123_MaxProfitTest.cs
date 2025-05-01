using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0123_MaxProfitTest
{
    [Theory]
    [InlineData(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 }, 6)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitIII(int[] prices, int expected)
    {
        var actual = _0123_MaxProfit.MaxProfit(prices);
        Assert.Equal(expected, actual);
    }
}
