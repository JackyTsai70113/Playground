namespace playground.UnitTest.LeetCode._3000_3999;

public class _3164_NumberOfPairsTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 4 }, new int[] { 1, 3, 4 }, 1, 5)]
    [InlineData(new int[] { 1, 2, 4, 12 }, new int[] { 2, 4 }, 3, 2)]
    public void NumberOfPairs(int[] nums1, int[] nums2, int k, long expected)
    {
        var actual = _3164_NumberOfPairs.NumberOfPairs(nums1, nums2, k);
        Assert.Equal(expected, actual);
    }
}
