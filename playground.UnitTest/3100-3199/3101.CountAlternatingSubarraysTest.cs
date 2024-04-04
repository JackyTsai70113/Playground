namespace playground.UnitTest;

public class CountAlternatingSubarraysTest3101
{
    [Theory]
    [InlineData(new int[] { 0, 1, 1, 1 }, 5)]
    [InlineData(new int[] { 1, 0, 1, 0 }, 10)]
    public void CountAlternatingSubarrays(int[] nums, long expected)
    {
        var actual = CountAlternatingSubarrays3101.CountAlternatingSubarrays(nums);
        Assert.Equal(expected, actual);
    }
}
