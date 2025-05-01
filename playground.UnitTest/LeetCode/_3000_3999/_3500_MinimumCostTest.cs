using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3500_MinimumCostTest
{
    [Theory]
    [InlineData(
        new int[] { 3, 1, 4 },
        new int[] { 4, 6, 6 },
        1, 110)]
    [InlineData(
        new int[] { 4, 8, 5 },
        new int[] { 7, 2, 8 },
        7, 387)]
    [InlineData(
        new int[] { 4, 8, 5, 1, 14, 2, 2, 12, 1 },
        new int[] { 7, 2, 8, 4, 2, 2, 1, 1, 2 },
        7, 985)]
    public void MinimumCost(int[] nums, int[] cost, int k, long expected)
    {
        var actual = _3500_MinimumCost.MinimumCost(nums, cost, k);
        Assert.Equal(expected, actual);
    }
}
