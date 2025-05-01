using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0350_IntersectTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
    [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
    public void Intersect(int[] nums1, int[] nums2, int[] expected)
    {
        var actual = _0350_Intersect.Intersect(nums1, nums2);
        Assert.Equal(expected, actual.OrderBy(x => x));
    }
}
