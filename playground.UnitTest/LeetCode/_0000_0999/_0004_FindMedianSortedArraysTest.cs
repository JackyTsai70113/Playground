using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0004_FindMedianSortedArraysTest
{
    [Theory]
    [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.00000)]
    [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.50000)]
    [InlineData(new int[] { 100001 }, new int[] { 100000 }, 100000.50000)]
    public void FindMedianSortedArrays(int[] nums1, int[] nums2, double expected)
    {
        var actual = _0004_FindMedianSortedArrays.FindMedianSortedArrays(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}
