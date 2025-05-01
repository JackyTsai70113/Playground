using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2183_CountPairsTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 7)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 5, 0)]
    public void CountPairs(int[] nums, int k, int expected)
    {
        var actual = _2183_CountPairs.CountPairs(nums, k);
        Assert.Equal(expected, actual);
    }
}
