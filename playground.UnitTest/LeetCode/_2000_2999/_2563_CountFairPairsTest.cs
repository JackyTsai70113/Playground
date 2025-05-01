using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2563_CountFairPairsTest_cs
{
    [Theory]
    [InlineData(new int[] { 0, 1, 7, 4, 4, 5 }, 3, 6, 6)]
    [InlineData(new int[] { 1, 7, 9, 2, 5 }, 11, 11, 1)]
    public void CountFairPairs(int[] nums, int lower, int upper, long expected)
    {
        var actual = _2563_CountFairPairs.CountFairPairs(nums, lower, upper);
        Assert.Equal(expected, actual);
    }
}
