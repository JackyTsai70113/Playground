namespace playground.UnitTest;

public class GetCommonTest2540
{
    [Theory]
    [InlineData("[1,2,3]", "[2,4]", 2)]
    [InlineData("[1,2,3,6]", "[2,3,4,5]", 2)]
    [InlineData("[2,3,4,5]", "[1,2,3,6]", 2)]
    [InlineData("[2,3,4,5]", "[1,6]", -1)]
    public void GetCommon(string nums1, string nums2, int expected)
    {
        var actual = GetCommon2540.GetCommon(nums1.ToArr(), nums2.ToArr());
        Assert.Equal(expected, actual);
    }
}
