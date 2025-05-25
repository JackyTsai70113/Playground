using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1035_MaxUncrossedLinesTest
{
    [Theory]
    [InlineData(new int[] { 1, 4, 2 }, new int[] { 1, 2, 4 }, 2)]
    [InlineData(new int[] { 2, 5, 1, 2, 5 }, new int[] { 10, 5, 2, 1, 5, 2 }, 3)]
    [InlineData(new int[] { 1, 3, 7, 1, 7, 5 }, new int[] { 1, 9, 2, 5, 1 }, 2)]
    public void MaxUncrossedLines(int[] nums1, int[] nums2, int expected)
    {
        int actual;
        actual = _1035_MaxUncrossedLines.MaxUncrossedLines_TopDown(nums1, nums2);
        Assert.Equal(expected, actual);
        actual = _1035_MaxUncrossedLines.MaxUncrossedLines_BottomUp(nums1, nums2);
        Assert.Equal(expected, actual);
        actual = _1035_MaxUncrossedLines.MaxUncrossedLines_OptimizeSpace(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}
