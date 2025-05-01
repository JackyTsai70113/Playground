using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2913_SumCountsTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1 }, 15)]
    [InlineData(new int[] { 1, 1 }, 3)]
    public void SumCounts(int[] nums, int expected)
    {
        var actual = _2913_SumCounts.SumCounts(nums);
        Assert.Equal(expected, actual);
    }
}
