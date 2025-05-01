using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2597_BeautifulSubsetsTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 1, 4)]
    [InlineData(new int[] { 1, 1, 2 }, 2, 7)]
    [InlineData(new int[] { 2, 4, 6 }, 2, 4)]
    [InlineData(new int[] { 1 }, 1, 1)]
    public void BeautifulSubsets(int[] nums, int k, int expected)
    {
        var actual = _2597_BeautifulSubsets.BeautifulSubsets(nums, k);
        Assert.Equal(expected, actual);
    }
}
