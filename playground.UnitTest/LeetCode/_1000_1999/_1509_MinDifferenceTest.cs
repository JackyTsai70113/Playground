namespace playground.UnitTest;

public class _1509_MinDifferenceTest
{
    [Theory]
    [InlineData(new int[] { 5, 3, 2, 4 }, 0)]
    [InlineData(new int[] { 1, 5, 0, 10, 14 }, 1)]
    [InlineData(new int[] { 3, 100, 20 }, 0)]
    public void MinDifference(int[] nums, int expected)
    {
        var actual = _1509_MinDifference.MinDifference(nums);
        Assert.Equal(expected, actual);
    }
}
