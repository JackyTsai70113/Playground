using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3562_MaxProfitTest
{
    [Theory]
    [InlineData(2, new[] { 1, 2 }, new[] { 4, 3 }, "[[1,2]]", 3, 5)]
    [InlineData(2, new[] { 3, 4 }, new[] { 5, 8 }, "[[1,2]]", 4, 4)]
    [InlineData(3, new[] { 4, 6, 8 }, new[] { 7, 9, 11 }, "[[1,2],[1,3]]", 10, 10)]
    [InlineData(3, new[] { 5, 2, 3 }, new[] { 8, 5, 6 }, "[[1,2],[2,3]]", 7, 12)]
    [InlineData(2, new[] { 6, 11 }, new[] { 5, 48 }, "[[1,2]]", 142, 42)]
    public void MaxProfit(int n, int[] presentPrices, int[] futurePrices, string hierarchy, int budget, int expected)
    {
        var actual = new _3562_MaxProfit().MaxProfit(n, presentPrices, futurePrices, hierarchy.To2dArr(), budget);
        Assert.Equal(expected, actual);
    }
}
