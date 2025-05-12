using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3013_MinimumCostTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 2, 6, 4, 2 }, 3, 3, 5)]
    [InlineData(new int[] { 10, 1, 2, 2, 2, 1 }, 4, 3, 15)]
    [InlineData(new int[] { 10, 8, 18, 9 }, 3, 1, 36)]
    [InlineData(new int[] { 2, 6, 3, 8, 3, 1, 1 }, 3, 4, 4)]
    [InlineData(new int[] { 20, 43, 21, 19, 3, 39, 40, 37, 32, 12 }, 5, 4, 102)]
    [InlineData(new int[] { 6, 40, 41, 11, 50, 15, 47, 48, 50, 12, 16, 30, 38, 45, 26, 25, 32, 28 }, 8, 10, 168)]
    [InlineData(new int[] { 36, 28, 42, 36, 39, 13, 24, 3, 32, 16, 11, 43, 21, 40, 34, 49, 29, 20, 34, 34, 8, 3, 41, 6, 46, 5, 35, 5, 47, 2 }, 25, 26, 570)]
    [InlineData(new int[] { 36, 39, 13, 24, 11, 43, 21, 40, 34, 8, 3, 41, 6, 47, 2 }, 10, 11, 185)]
    public void MinimumCost(int[] nums, int k, int dist, long expected)
    {
        var actual = _3013_MinimumCost.MinimumCost(nums, k, dist);
        Assert.Equal(expected, actual);
    }
}
