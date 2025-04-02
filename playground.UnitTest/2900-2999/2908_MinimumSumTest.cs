using playground._2900_2999;

namespace playground.UnitTest._2900_2999;

public class _2908_MinimumSumTest
{
    [Theory]
    [InlineData(new int[] { 8, 6, 1, 5, 3 }, 9)]
    [InlineData(new int[] { 5, 4, 8, 7, 10, 2 }, 13)]
    [InlineData(new int[] { 6, 5, 4, 3, 4, 5 }, -1)]
    [InlineData(new int[] { 1, 2, 3, 2 }, 6)]
    public void MinimumSum(int[] nums, int expected)
    {
        var actual = _2908_MinimumSum.MinimumSum(nums);
        Assert.Equal(expected, actual);
    }
}
