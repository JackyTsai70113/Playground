using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0532_FindPairsTest
{
    [Theory]
    [InlineData(new int[] { 3, 1, 4, 1, 5 }, 2, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, 4)]
    [InlineData(new int[] { 1, 3, 1, 5, 4 }, 0, 1)]
    public void FindPairs(int[] nums, int k, int expected)
    {
        var actual = _0532_FindPairs.FindPairs(nums, k);
        Assert.Equal(expected, actual);
        actual = _0532_FindPairs.FindPairs2(nums, k);
        Assert.Equal(expected, actual);
    }
}
