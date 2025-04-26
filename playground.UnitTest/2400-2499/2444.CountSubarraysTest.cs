namespace playground.UnitTest;

public class CountSubarraysTest2444
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 2, 7, 5 }, 1, 5, 2)]
    [InlineData(new int[] { 1, 3, 5, 2, -1, 5 }, 1, 5, 2)]
    [InlineData(new int[] { 1, 1, 1, 1 }, 1, 1, 10)]
    public void CountSubarrays(int[] nums, int minK, int maxK, long expected)
    {
        var actual = _2444_CountSubarrays.CountSubarrays(nums, minK, maxK);
        Assert.Equal(expected, actual);
    }
}
