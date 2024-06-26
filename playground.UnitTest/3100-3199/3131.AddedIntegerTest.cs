namespace playground.UnitTest;

public class AddedIntegerTest3131
{
    [Theory]
    [InlineData(new int[] { 2, 6, 4 }, new int[] { 9, 7, 5 }, 3)]
    [InlineData(new int[] { 10 }, new int[] { 5 }, -5)]
    [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, 0)]
    public void NumberOfRightTriangles(int[] nums1, int[] nums2, int expected)
    {
        var actual = AddedInteger3131.AddedInteger(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}
