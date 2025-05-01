namespace playground.UnitTest;

public class _3101_CountAlternatingSubarraysTest
{
    [Theory]
    [InlineData(new int[] { 0, 1, 1, 1 }, 5)]
    [InlineData(new int[] { 1, 0, 1, 0 }, 10)]
    public void CountAlternatingSubarrays(int[] nums, long expected)
    {
        var actual = _3101_CountAlternatingSubarrays.CountAlternatingSubarrays(nums);
        Assert.Equal(expected, actual);
    }
}
