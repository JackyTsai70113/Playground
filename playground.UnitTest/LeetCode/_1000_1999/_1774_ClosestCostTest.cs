using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1774_ClosestCostTest
{
    [Theory]
    [InlineData(new[] { 1, 7 }, new[] { 3, 4 }, 10, 10)]
    [InlineData(new[] { 2, 3 }, new[] { 4, 5, 100 }, 18, 17)]
    [InlineData(new[] { 3, 10 }, new[] { 2, 5 }, 9, 8)]
    [InlineData(new[] { 10 }, new[] { 1 }, 1, 10)]
    public void ClosestCost(int[] baseCosts, int[] toppingCosts, int target, int expected)
    {
        var actual = _1774_ClosestCost.ClosestCost(baseCosts, toppingCosts, target);
        Assert.Equal(expected, actual);
    }
}
