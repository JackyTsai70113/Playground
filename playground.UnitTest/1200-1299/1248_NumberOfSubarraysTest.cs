namespace playground.UnitTest;

public class _1248_NumberOfSubarraysTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 1, 1 }, 3, 2)]
    [InlineData(new int[] { 2, 4, 6 }, 1, 0)]
    [InlineData(new int[] { 2, 2, 2, 1, 2, 2, 1, 2, 2, 2 }, 2, 16)]
    public void SubarraysWithKDistinct(int[] nums, int k, int expected)
    {
        var actual = _1248_NumberOfSubarrays.NumberOfSubarrays(nums, k);
        Assert.Equal(expected, actual);
    }
}
