namespace playground.UnitTest;

public class MinimumAddedIntegerTest3132
{
    [Theory]
    [InlineData(new int[] { 4, 20, 16, 12, 8 }, new int[] { 14, 18, 10 }, -2)]
    [InlineData(new int[] { 3, 5, 5, 3 }, new int[] { 7, 7 }, 2)]
    public void MinimumAddedInteger(int[] nums1, int[] nums2, int expected)
    {
        var actual = MinimumAddedInteger3132.MinimumAddedInteger(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}
