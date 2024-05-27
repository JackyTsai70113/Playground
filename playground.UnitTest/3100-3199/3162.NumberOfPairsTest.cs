namespace playground.UnitTest;

public class NumberOfPairsTest3162
{
    [Theory]
    [InlineData(new int[] { 1, 3, 4 }, new int[] { 1, 3, 4 }, 1, 5)]
    [InlineData(new int[] { 1, 2, 4, 12 }, new int[] { 2, 4 }, 3, 2)]
    public void NumberOfPairs(int[] nums1, int[] nums2, int k, long expected)
    {
        var actual = NumberOfPairs3162.NumberOfPairs(nums1, nums2, k);
        Assert.Equal(expected, actual);
    }
}
