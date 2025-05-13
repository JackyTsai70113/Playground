namespace playground.UnitTest.LeetCode._1000_1999;

public class _1508_RangeSumTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 1, 5, 13)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 3, 4, 6)]
    public void RangeSum(int[] nums, int n, int left, int right, int expected)
    {
        var actual = _1508_RangeSum.RangeSum(nums, n, left, right);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 1, 5, 13)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 3, 4, 6)]
    public void RangeSum2(int[] nums, int n, int left, int right, int expected)
    {
        var actual = new _1508_RangeSum().RangeSum2(nums, n, left, right);
        Assert.Equal(expected, actual);
    }
}
