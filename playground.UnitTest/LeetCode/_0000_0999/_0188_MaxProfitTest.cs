using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0188_MaxProfitTest
{
    [Theory]
    [InlineData(2, new int[] { 2, 4, 1 }, 2)]
    [InlineData(2, new int[] { 3, 2, 6, 5, 0, 3 }, 7)]
    public void MaxProfit(int k, int[] prices, int expected)
    {
        var actual = _0188_MaxProfit.MaxProfit(k, prices);
        Assert.Equal(expected, actual);
    }
}
