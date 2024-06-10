namespace playground.UnitTest;

public class MaxProfitTest0121
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfit(int[] prices, int expected)
    {
        var actual = MaxProfit0121.MaxProfit(prices);
        Assert.Equal(expected, actual);
    }
}
