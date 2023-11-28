namespace playground.UnitTest;

public class LongestAlternatingSubarrayTest_2760
{
    [Theory]
    // [InlineData(new int[] { 3, 2, 5, 4 }, 5, 3)]
    // [InlineData(new int[] { 1, 2 }, 2, 1)]
    // [InlineData(new int[] { 2, 3, 4, 5 }, 4, 3)]
    [InlineData(new int[] { 4, 10, 3 }, 10, 2)]
    public void LongestAlternatingSubarray(int[] nums, int threshold, int expected)
    {
        var actual = LongestAlternatingSubarray_2760.LongestAlternatingSubarray(nums, threshold);
        Assert.Equal(expected, actual);
    }
}
