using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0813_LargestSumOfAveragesTest
{
    [Theory]
    [InlineData(new int[] { 9, 1, 2, 3, 9 }, 3, 20.00000)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 4, 20.50000)]
    public void LargestSumOfAverages(int[] nums, int k, double expected)
    {
        var actual = _0813_LargestSumOfAverages.LargestSumOfAverages(nums, k);
        Assert.Equal(expected, actual);
    }
}
