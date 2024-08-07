namespace playground.UnitTest;

public class RangeSumTest1508
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 1, 5, 13)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 3, 4, 6)]
    public void RangeSum(int[] nums, int n, int left, int right, int expected)
    {
        var actual = RangeSum1508.RangeSum(nums, n, left, right);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 1, 5, 13)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 3, 4, 6)]
    public void RangeSum2(int[] nums, int n, int left, int right, int expected)
    {
        var actual = new RangeSum1508().RangeSum2(nums, n, left, right);
        Assert.Equal(expected, actual);
    }
}
