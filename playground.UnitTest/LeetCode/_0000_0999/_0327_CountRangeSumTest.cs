using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0327_CountRangeSumTest
{
    [Theory]
    [InlineData(new int[] { -2, 5, -1 }, -2, 2, 3)]
    [InlineData(new int[] { -2, 5, -10 }, -2, 2, 1)]
    [InlineData(new int[] { 0 }, 0, 0, 1)]
    [InlineData(new int[] { 0, 0 }, 0, 0, 3)]
    public void CountRangeSum(int[] nums, int lower, int upper, int expected)
    {
        var actual =  _0327_CountRangeSum.CountRangeSum(nums, lower, upper);
        Assert.Equal(expected, actual);
    }
}
