using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MaxUncrossedLinesTest
{
    [Theory]
    [InlineData(new int[] { 1, 4, 2 }, new int[] { 1, 2, 4 }, 2)]
    [InlineData(new int[] { 2, 5, 1, 2, 5 }, new int[] { 10, 5, 2, 1, 5, 2 }, 3)]
    [InlineData(new int[] { 1, 3, 7, 1, 7, 5 }, new int[] { 1, 9, 2, 5, 1 }, 2)]
    public void MaxUncrossedLines(int[] nums1, int[] nums2, int expected)
    {
        int actual = MaxUncrossedLinesClass.MaxUncrossedLines(nums1, nums2);

        Assert.Equal(expected, actual);
    }
}
