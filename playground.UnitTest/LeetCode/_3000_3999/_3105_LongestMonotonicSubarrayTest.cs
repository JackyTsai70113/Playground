namespace playground.UnitTest;

public class _3105_LongestMonotonicSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 4, 3, 3, 2 }, 2)]
    [InlineData(new int[] { 3, 3, 3, 3 }, 1)]
    [InlineData(new int[] { 3, 2, 1 }, 3)]
    public void LongestMonotonicSubarray(int[] nums, int expected)
    {
        var actual = _3105_LongestMonotonicSubarray.LongestMonotonicSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
