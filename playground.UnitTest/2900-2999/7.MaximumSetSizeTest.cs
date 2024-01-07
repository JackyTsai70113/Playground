namespace playground.UnitTest;

public class MaximumSetSizeTest7
{
    [Theory]
    [InlineData("[1,2,1,2]", "[1,1,1,1]", 2)]
    [InlineData("[1,2,3,4,5,6]", "[2,3,2,3,2,3]", 5)]
    [InlineData("[1,1,2,2,3,3]", "[4,4,5,5,6,6]", 6)]
    public void MaximumSetSize(string nums1, string nums2, int expected)
    {
        var actual = MaximumSetSize7.MaximumSetSize(nums1.ToArr(), nums2.ToArr());
        Assert.Equal(expected, actual);
    }
}
