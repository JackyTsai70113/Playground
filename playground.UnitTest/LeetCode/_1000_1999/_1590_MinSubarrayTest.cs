using playground_1500_1599;

namespace playground.UnitTest_1500_1599;

public class _1590_MinSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 3, 1, 4, 2 }, 6, 1)]
    [InlineData(new int[] { 6, 3, 5, 2 }, 9, 2)]
    [InlineData(new int[] { 1, 2, 3 }, 3, 0)]
    [InlineData(new int[] { 1, 2, 3 }, 7, -1)]
    public void MinSubarray(int[] nums, int p, int expected)
    {
        var actual = _1590_MinSubarray_cs.MinSubarray(nums, p);
        Assert.Equal(expected, actual);
    }
}
