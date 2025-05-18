using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3346_MaxFrequencyTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 4 }, 5, 3, 3)]
    [InlineData(new[] { 1, 4, 5 }, 1, 2, 2)]
    [InlineData(new[] { 5, 11, 20, 20 }, 5, 1, 2)]
    [InlineData(new[] { 1, 3 }, 1, 2, 2)]
    [InlineData(new[] { 2 }, 7, 0, 1)]
    [InlineData(new[] { 3 }, 8, 1, 1)]
    public void MaxFrequency(int[] nums, int k, int numOperations, int expected)
    {
        var result = _3346_MaxFrequency.MaxFrequency(nums, k, numOperations);
        Assert.Equal(expected, result);
    }
}