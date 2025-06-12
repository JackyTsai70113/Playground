using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3573_MaximumProfitTest
{
    [Theory]
    [InlineData(new int[] { 1, 7, 9, 8, 2 }, 2, 14)]
    [InlineData(new int[] { 12, 16, 19, 19, 8, 1, 19, 13, 9 }, 3, 36)]
    public void MaximumProfit(int[] A, int k, long expected)
    {
        var actual = _3573_MaximumProfit.MaximumProfit(A, k);
        Assert.Equal(expected, actual);
    }
}
