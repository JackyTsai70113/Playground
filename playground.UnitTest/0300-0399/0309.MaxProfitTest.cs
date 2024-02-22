namespace playground.UnitTest;

public class MaxProfitTest0309
{
    [Theory]
    [InlineData(new int[] { 1, 7, 3, 0, 4, 2 }, 10)]
    [InlineData(new int[] { 1, 2, 3, 0, 2 }, 3)]
    [InlineData(new int[] { 1 }, 0)]
    public void MaxProfitCoolDown(int[] prices, int expected)
    {
        var actual = MaxProfit0309.MaxProfit(prices);
        Assert.Equal(expected, actual);
    }
}
