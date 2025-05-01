using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2616_MinimizeMaxTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 3, 4 }, 3, 1)]
    [InlineData(new int[] { 2, 2, 2, 3, 3, 4 }, 3, 1)]
    [InlineData(new int[] { 10, 1, 3, 7, 5, 9, 5 }, 3, 2)]
    [InlineData(new int[] { 4, 2, 1 }, 1, 1)]
    [InlineData(new int[] { 3, 0, 5, 0, 0, 1, 6 }, 3, 1)]
    [InlineData(new int[] { 4, 2, 2, 1 }, 1, 0)]
    [InlineData(new int[] { 1 }, 0, 0)]
    [InlineData(new int[] { 1, 2 }, 0, 0)]
    public void MinimizeMax(int[] nums, int p, int expected)
    {
        int actual = _2616_MinimizeMax.MinimizeMax(nums, p);
        Assert.Equal(expected, actual);
    }
}