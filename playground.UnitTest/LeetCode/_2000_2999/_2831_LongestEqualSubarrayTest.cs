using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2831_LongestEqualSubarrayTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 0, 1)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 1, 1)]
    [InlineData(new[] { 1, 3, 2, 3, 1, 3 }, 3, 3)]
    [InlineData(new[] { 1, 1, 2, 2, 1, 1 }, 2, 4)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 3, 3 }, 0, 4)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 1 }, 0, 1)]
    public void LongestEqualSubarrayTest(int[] nums, int k, int expected)
    {
        var result = _2831_LongestEqualSubarray.LongestEqualSubarray(nums, k);
        Assert.Equal(expected, result);
    }
}
