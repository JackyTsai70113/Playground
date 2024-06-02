namespace playground.UnitTest;

public class MinimumDifferenceTest3171
{
    [Theory]
    [InlineData(new int[] { 1, 2, 4, 5 }, 3, 1)]
    [InlineData(new int[] { 1, 2, 1, 2 }, 2, 0)]
    [InlineData(new int[] { 1 }, 10, 9)]
    public void MinimumDifference(int[] nums, int k, int expected)
    {
        var actual = MinimumDifference3171.MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}
