using playground.DynamicProgramming;

namespace playground.UnitTest.Arrays;

public class MaxNonDecreasingLengthTest
{
    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 }, 1)]
    [InlineData(new int[] { 8, 7, 4 }, new int[] { 13, 4, 4 }, 2)]
    [InlineData(new int[] { 1, 19, 6 }, new int[] { 11, 6, 1 }, 3)]
    [InlineData(new int[] { 2, 3, 1 }, new int[] { 1, 2, 1 }, 2)]
    [InlineData(new int[] { 1, 3, 2, 1 }, new int[] { 2, 2, 3, 4 }, 4)]
    [InlineData(new int[] { 1, 1 }, new int[] { 2, 2 }, 2)]
    public void MaxNonDecreasingLength(int[] nums1, int[] nums2, int expected)
    {
        var actual = MaxNonDecreasingLengthClass.MaxNonDecreasingLength(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}
