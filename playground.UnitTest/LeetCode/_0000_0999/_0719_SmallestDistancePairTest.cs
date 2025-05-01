using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0719_SmallestDistancePairTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 1 }, 1, 0)]
    [InlineData(new int[] { 1, 1, 1 }, 2, 0)]
    [InlineData(new int[] { 1, 6, 1 }, 3, 5)]
    public void SmallestDistancePair(int[] nums, int k, int expected)
    {
        var actual = _0719_SmallestDistancePair.SmallestDistancePair(nums, k);
        Assert.Equal(expected, actual);
    }
}
