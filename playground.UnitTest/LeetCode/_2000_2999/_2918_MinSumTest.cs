using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2918_MinSumTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 0, 0, 0 }, 6)]
    [InlineData(new[] { 0, 0, 0 }, new[] { 1, 2, 3 }, 6)]
    [InlineData(new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, 3)]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, 6)]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }, -1)]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3 }, -1)]
    public void MinSumTest(int[] nums1, int[] nums2, long expected)
    {
        var result = _2918_MinSum.MinSum(nums1, nums2);
        Assert.Equal(expected, result);
    }
}
