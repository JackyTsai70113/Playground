namespace playground.UnitTest;

public class MaxProfitTest0122
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfit(int[] prices, int expected)
    {
        var actual = MaxProfit0122.MaxProfit(prices);
        Assert.Equal(expected, actual);
    }
}
