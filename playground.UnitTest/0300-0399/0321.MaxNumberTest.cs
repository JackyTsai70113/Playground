namespace playground.UnitTest;

public class MaxNumberTest0321
{
    [Theory]
    [InlineData(new int[] { 3, 3 }, new int[] { 3, 3 }, 4, new int[] { 3, 3, 3, 3 })]
    [InlineData(new int[] { 3, 4, 6, 5 }, new int[] { 9, 1, 2, 5, 8, 3 }, 5, new int[] { 9, 8, 6, 5, 3 })]
    [InlineData(new int[] { 6, 7 }, new int[] { 6, 0, 4 }, 5, new int[] { 6, 7, 6, 0, 4 })]
    [InlineData(new int[] { 3, 9 }, new int[] { 8, 9 }, 3, new int[] { 9, 8, 9 })]
    [InlineData(new int[] { 8, 1, 8, 8, 6 }, new int[] { 4 }, 2, new int[] { 8, 8 })]
    [InlineData(new int[] { 6, 7, 5 }, new int[] { 4, 8, 1 }, 3, new int[] { 8, 7, 5 })]
    [InlineData(new int[] { 6, 6, 8 }, new int[] { 5, 0, 9 }, 3, new int[] { 9, 6, 8 })]
    public void MaxNumber(int[] nums1, int[] nums2, int k, int[] expected)
    {
        var actual = MaxNumber0321.MaxNumber(nums1, nums2, k);
        Assert.Equal(expected, actual);
    }
}
