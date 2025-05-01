using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0493_ReversePairsTest
{
    [Theory]
    [InlineData(new int[] { 2147483647, 2147483647 }, 0)]
    [InlineData(new int[] { 3, 1 }, 1)]
    [InlineData(new int[] { 1, 3, 2, 3, 1 }, 2)]
    [InlineData(new int[] { 2, 4, 3, 5, 1 }, 3)]
    public void ReversePairs(int[] nums, int expected)
    {
        var actual = _0493_ReversePairs.ReversePairs(nums);
        Assert.Equal(expected, actual);
    }
}
