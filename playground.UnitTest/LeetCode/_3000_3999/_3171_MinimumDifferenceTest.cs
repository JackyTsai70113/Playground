namespace playground.UnitTest;

public class _3171_MinimumDifferenceTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 4, 5 }, 3, 1)]
    [InlineData(new int[] { 1, 2, 1, 2 }, 2, 0)]
    [InlineData(new int[] { 1 }, 10, 9)]
    public void MinimumDifference(int[] nums, int k, int expected)
    {
        var actual = _3171_MinimumDifference.MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}
