using playground.Greedy;

namespace playground.UnitTest.Greedy;

public class MinSumTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 0, 1, 0 }, new int[] { 6, 5, 0 }, 12)]
    [InlineData(new int[] { 2, 0, 2, 0 }, new int[] { 1, 4 }, -1)]
    [InlineData(new int[] { 1, 4 }, new int[] { 2, 0, 2, 0 }, -1)]
    public void MinSum(int[] nums1, int[] nums2, int expected)
    {
        var actual = MinSumClass.MinSum(nums1, nums2);

        Assert.Equal(expected, actual);
    }
}
