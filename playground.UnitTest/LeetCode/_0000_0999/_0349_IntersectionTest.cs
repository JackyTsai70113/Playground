using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0349_IntersectionTest
{
    [Theory]
    [InlineData("[1,2,2,1]", "[2,2]", "[2]")]
    [InlineData("[4,9,5]", "[9,4,9,8,4]", "[9,4]")]
    public void Intersection(string nums1, string nums2, string expected)
    {
        var actual = _0349_Intersection.Intersection(nums1.ToArr(), nums2.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
