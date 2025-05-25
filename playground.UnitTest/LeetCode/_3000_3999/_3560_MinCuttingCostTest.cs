using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3560_MinCuttingCostTest
{
    [Theory]
    [InlineData(4, 4, 6, 0)]
    [InlineData(5, 6, 5, 5)]
    [InlineData(6, 5, 5, 5)]
    public void MinCuttingCost(int n, int m, int k, long expected)
    {
        var result = _3560_MinCuttingCost.MinCuttingCost(n, m, k);
        Assert.Equal(expected, result);
    }
}
