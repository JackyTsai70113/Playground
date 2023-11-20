namespace playground.UnitTest;

public class SumCountsTest_2913
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1 }, 15)]
    [InlineData(new int[] { 1, 1 }, 3)]
    public void SumCounts(int[] nums, int expected)
    {
        var actual = SumCounts_2913.SumCounts(nums);
        Assert.Equal(expected, actual);
    }
}
