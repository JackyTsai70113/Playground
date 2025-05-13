namespace playground.UnitTest.LeetCode._1000_1999;

public class _1425_ConstrainedSubsetSumTest
{
    [Theory]
    [InlineData(new int[] { 10, 2, -10, 5, 20 }, 2, 37)]
    [InlineData(new int[] { -1, -2, -3 }, 1, -1)]
    [InlineData(new int[] { 10, -2, -10, -5, 20 }, 2, 23)]
    public void ConstrainedSubsetSum(int[] nums, int k, int expected)
    {
        var actual = _1425_ConstrainedSubsetSum.ConstrainedSubsetSum(nums, k);
        Assert.Equal(expected, actual);
    }
}
