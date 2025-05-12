using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1590_MinSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 3, 1, 4, 2 }, 6, 1)]
    [InlineData(new int[] { 6, 3, 5, 2 }, 9, 2)]
    [InlineData(new int[] { 1, 2, 3 }, 3, 0)]
    [InlineData(new int[] { 1, 2, 3 }, 7, -1)]
    public void MinSubarray(int[] nums, int p, int expected)
    {
        var actual = _1590_MinSubarray.MinSubarray(nums, p);
        Assert.Equal(expected, actual);
    }
}
