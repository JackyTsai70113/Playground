using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2134_MinSwapsTest
{
    [Theory]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { 0, 1, 0, 1, 1, 0, 0 }, 1)]
    [InlineData(new int[] { 0, 1, 1, 1, 0, 0, 1, 1, 0 }, 2)]
    [InlineData(new int[] { 1, 1, 0, 0, 1 }, 0)]
    [InlineData(new int[] { 0, 0, 0 }, 0)]
    [InlineData(new int[] { 1, 1, 1 }, 0)]
    [InlineData(new int[] { 1, 1, 1, 0, 0, 1, 0, 1, 1, 0 }, 1)]
    public void MinSwaps(int[] nums, int expected)
    {
        var actual = _2134_MinSwaps.MinSwaps(nums);
        Assert.Equal(expected, actual);
    }
}
