using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3587_MinSwapsTest
{
    [Theory]
    [InlineData(new[] { 2, 4, 6, 5, 7 }, 3)]
    [InlineData(new[] { 2, 4, 5, 7 }, 1)]
    [InlineData(new[] { 1, 2, 3 }, 0)]
    [InlineData(new[] { 4, 5, 6, 8 }, -1)]
    public void MinSwaps(int[] nums, int expected)
    {
        var actual = _3587_MinSwaps.MinSwaps(nums);
        Assert.Equal(expected, actual);
    }
}
