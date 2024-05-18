namespace playground.UnitTest;

public class IntersectionTest0349
{
    [Theory]
    [InlineData("[1,2,2,1]", "[2,2]", "[2]")]
    [InlineData("[4,9,5]", "[9,4,9,8,4]", "[9,4]")]
    public void Intersection(string nums1, string nums2, string expected)
    {
        var actual = Intersection0349.Intersection(nums1.ToArr(), nums2.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
