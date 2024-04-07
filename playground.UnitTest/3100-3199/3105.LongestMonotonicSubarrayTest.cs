namespace playground.UnitTest;

public class LongestMonotonicSubarrayTest3105
{
    [Theory]
    [InlineData(new int[] { 1, 4, 3, 3, 2 }, 2)]
    [InlineData(new int[] { 3, 3, 3, 3 }, 1)]
    [InlineData(new int[] { 3, 2, 1 }, 3)]
    public void LongestMonotonicSubarray(int[] nums, int expected)
    {
        var actual = LongestMonotonicSubarray3105.LongestMonotonicSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
