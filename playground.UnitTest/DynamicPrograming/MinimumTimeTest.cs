using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MinimumTimeTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, 4, 3)]
    [InlineData(new int[] { 1, 2, 1 }, new int[] { 1, 2, 3 }, 4, 0)]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 }, 4, -1)]
    [InlineData(new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 }, new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 10, -1)]
    [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 10, -1)]
    [InlineData(new int[] { 4, 5, 3, 2, 3, 9, 5, 7, 10, 4 }, new int[] { 4, 4, 0, 4, 1, 2, 4, 0, 4, 0 }, 47, -1)]
    public void MinimumTime(IList<int> nums1, IList<int> nums2, int x, int expected)
    {
        var actual = MinimumTimeClass.MinimumTime(nums1, nums2, x);
        Assert.Equal(expected, actual);
    }
}
