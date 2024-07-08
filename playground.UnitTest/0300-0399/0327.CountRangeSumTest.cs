namespace playground.UnitTest;

public class CountRangeSumTest0327
{
    [Theory]
    [InlineData(new int[] { -2, 5, -10 }, -2, 2, 1)]
    [InlineData(new int[] { -2, 5, -1 }, -2, 2, 3)]
    [InlineData(new int[] { 0 }, 0, 0, 1)]
    [InlineData(new int[] { 0, 0 }, 0, 0, 3)]
    public void CountRangeSum(int[] nums, int lower, int upper, int expected)
    {
        var actual = new CountRangeSum0327().CountRangeSum(nums, lower, upper);
        Assert.Equal(expected, actual);
    }
}
