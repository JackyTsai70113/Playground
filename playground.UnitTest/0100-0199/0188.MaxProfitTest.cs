namespace playground.UnitTest;

public class MaxProfitTest0188
{
    [Theory]
    [InlineData(2, new int[] { 2, 4, 1 }, 2)]
    [InlineData(2, new int[] { 3, 2, 6, 5, 0, 3 }, 7)]
    public void MaxProfit(int k, int[] prices, int expected)
    {
        var actual = MaxProfit0188.MaxProfit(k, prices);
        Assert.Equal(expected, actual);
    }
}
