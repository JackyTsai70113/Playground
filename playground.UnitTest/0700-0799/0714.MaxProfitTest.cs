namespace playground.UnitTest;

public class MaxProfitTest0714
{
    [Theory]
    [InlineData(new int[] { 1, 3, 2, 8, 4, 9 }, 2, 8)]
    [InlineData(new int[] { 1, 3, 7, 5, 10, 3 }, 3, 6)]
    public void MaxProfitWithFee(int[] prices, int fee, int expected)
    {
        var actual = MaxProfit0714.MaxProfit(prices, fee);
        Assert.Equal(expected, actual);
    }
}
