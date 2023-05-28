using playground.Greedy;

namespace playground.UnitTest.Greedy;

public class MaxScoreTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 3, 2 }, new int[] { 2, 1, 3, 4 }, 3, 12)]
    [InlineData(new int[] { 4, 2, 3, 1, 1 }, new int[] { 7, 5, 10, 9, 6 }, 1, 30)]
    [InlineData(new int[] { 40000, 20000, 30000, 10000, 10000, 40000, 20000, 30000, 10000, 10000 }, new int[] { 70000, 50000, 100000, 90000, 60000, 70000, 50000, 100000, 90000, 60000 }, 10, 11000000000)]
    public void MaxScore(int[] nums1, int[] nums2, int k, long expected)
    {
        var actual = MaxScoreClass.MaxScore(nums1, nums2, k);
        Assert.Equal(expected, actual);
    }
}
