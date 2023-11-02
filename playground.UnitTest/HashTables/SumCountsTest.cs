namespace playground.UnitTest.HashTables;

public class SumCountsTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1 }, 15)]
    [InlineData(new int[] { 1, 1 }, 3)]
    public void SimSumCountsTestilarPairs(int[] nums, int expected)
    {
        var actual = SumCountsClass.SumCounts(nums);
        Assert.Equal(expected, actual);
    }
}
