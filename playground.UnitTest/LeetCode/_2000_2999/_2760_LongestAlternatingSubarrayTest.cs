using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2760_LongestAlternatingSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 5, 4 }, 5, 3)]
    [InlineData(new int[] { 1, 2 }, 2, 1)]
    [InlineData(new int[] { 2, 3, 4, 5 }, 4, 3)]
    [InlineData(new int[] { 4, 10, 3 }, 10, 2)]
    public void LongestAlternatingSubarray(int[] nums, int threshold, int expected)
    {
        var actual = _2760_LongestAlternatingSubarray.LongestAlternatingSubarray(nums, threshold);
        Assert.Equal(expected, actual);
    }
}
