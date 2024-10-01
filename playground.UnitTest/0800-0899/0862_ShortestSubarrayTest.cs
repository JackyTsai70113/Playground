using playground_0800_0899;

namespace playground.UnitTest._0800_0899;

public class _0862_ShortestSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 1 }, 1, 1)]
    [InlineData(new int[] { 1, 2 }, 4, -1)]
    [InlineData(new int[] { 2, -1, 2 }, 3, 3)]
    [InlineData(new int[] { 84, -37, 32, 40, 95 }, 167, 3)]
    [InlineData(new int[] { -28, 81, -20, 28, -29 }, 89, 3)]
    [InlineData(new int[] { -34, 37, 51, 3, -12, -50, 51, 100, -47, 99, 34, 14, -13, 89, 31, -14, -44, 23, -38, 6 }, 151, 2)]
    public void ShortestSubarray(int[] nums, int k, int expected)
    {
        var actual = _0862_ShortestSubarray.ShortestSubarray(nums, k);
        Assert.Equal(expected, actual);
    }
}
