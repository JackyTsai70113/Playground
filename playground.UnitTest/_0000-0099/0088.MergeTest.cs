namespace playground.UnitTest;

public class MergeTest_0088
{
    [Theory]
    [InlineData("[1,2,3,0,0,0]", 3, "[2,5,6]", 3, "[1,2,2,3,5,6]")]
    [InlineData("[3,5,6,0,0,0]", 3, "[1,2,2]", 3, "[1,2,2,3,5,6]")]
    [InlineData("[1]", 1, "[]", 0, "[1]")]
    public void Merge(string nums1, int m, string nums2, int n, string expected)
    {
        var actual = nums1.ToArr();
        Merge_0088.Merge(actual, m, nums2.ToArr(), n);
        Assert.Equal(expected.ToArr(), actual);
    }
}
