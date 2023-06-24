using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class BestTimeToBuyAndSellStockTest
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfit(int[] prices, int expected)
    {
        var actual = BestTimeToBuyAndSellStock.MaxProfit(prices);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitII(int[] prices, int expected)
    {
        var actual = BestTimeToBuyAndSellStock.MaxProfitII(prices);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 }, 6)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitIII(int[] prices, int expected)
    {
        var actual = BestTimeToBuyAndSellStock.MaxProfitIII(prices);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, new int[] { 2, 4, 1 }, 2)]
    [InlineData(2, new int[] { 3, 2, 6, 5, 0, 3 }, 7)]
    public void MaxProfitIV(int k, int[] prices, int expected)
    {
        var actual = BestTimeToBuyAndSellStock.MaxProfitIV(k, prices);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 7, 3, 0, 4, 2 }, 10)]
    [InlineData(new int[] { 1, 2, 3, 0, 2 }, 3)]
    [InlineData(new int[] { 1 }, 0)]
    public void MaxProfitCoolDown(int[] prices, int expected)
    {
        var actual = BestTimeToBuyAndSellStock.MaxProfitCoolDown(prices);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 2, 8, 4, 9 }, 2, 8)]
    [InlineData(new int[] { 1, 3, 7, 5, 10, 3 }, 3, 6)]
    public void MaxProfitWithFee(int[] prices, int fee, int expected)
    {
        var actual = BestTimeToBuyAndSellStock.MaxProfitWithFee(prices, fee);
        Assert.Equal(expected, actual);
    }
}
