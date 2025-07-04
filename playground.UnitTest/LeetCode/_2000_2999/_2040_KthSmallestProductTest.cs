using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2040_KthSmallestProductTest
{
    [Theory]
    [InlineData(new[] { 2, 5 }, new[] { 3, 4 }, 2, 8)]
    [InlineData(new[] { -4, -2, 0, 3 }, new[] { 2, 4 }, 6, 0)]
    [InlineData(new[] { -2, -1, 0, 1, 2 }, new[] { -3, -1, 2, 4, 5 }, 3, -6)]
    public void TestKthSmallestProduct(int[] nums1, int[] nums2, long k, long expected)
    {
        long result = _2040_KthSmallestProduct.KthSmallestProduct(nums1, nums2, k);
        Assert.Equal(expected, result);
    }
}
