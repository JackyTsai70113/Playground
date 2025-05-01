using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0088_MergeTest
{
    [Theory]
    [InlineData("[1,2,3,0,0,0]", 3, "[2,5,6]", 3, "[1,2,2,3,5,6]")]
    [InlineData("[3,5,6,0,0,0]", 3, "[1,2,2]", 3, "[1,2,2,3,5,6]")]
    [InlineData("[1]", 1, "[]", 0, "[1]")]
    public void Merge(string nums1, int m, string nums2, int n, string expected)
    {
        var actual = nums1.ToArr();
        _0088_Merge.Merge(actual, m, nums2.ToArr(), n);
        Assert.Equal(expected.ToArr(), actual);
    }
}
