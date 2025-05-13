namespace playground.UnitTest.LeetCode._1000_1999;

public class _1803_CountPairsTest
{
    [Theory]
    [InlineData(new int[] { 1, 4, 2, 7 }, 2, 6, 6)]
    [InlineData(new int[] { 9, 8, 4, 2, 1 }, 5, 14, 8)]
    [InlineData(new int[] { 3856, 3174, 2182, 7497, 6155, 4589, 3581, 4548, 3982, 2508 }, 6903, 6946, 0)]
    public void CountPairs(int[] nums, int low, int high, int expected)
    {
        var actual = _1803_CountPairs.CountPairs(nums, low, high);
        Assert.Equal(expected, actual);
    }
}
