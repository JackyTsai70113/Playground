using playground._2800_2899;

namespace playground.UnitTest._2800_2899;

public class _2875_MinSizeSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 5, 2)]
    [InlineData(new int[] { 1, 2, 3 }, 6, 3)]
    [InlineData(new int[] { 1, 1, 1, 2, 3 }, 4, 2)]
    [InlineData(new int[] { 2, 4, 6, 8 }, 3, -1)]
    [InlineData(new int[] { 2, 1, 5, 7, 7, 1, 6, 3 }, 39, 9)]
    public void MinSizeSubarray(int[] nums, int target, int expected)
    {
        var actual = _2875_MinSizeSubarray.MinSizeSubarray(nums, target);
        Assert.Equal(expected, actual);
    }
}
