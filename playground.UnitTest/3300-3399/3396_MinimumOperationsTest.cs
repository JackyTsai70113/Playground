using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3396_MinimumOperationsTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 3, 3, 5, 7 }, 2)]
    [InlineData(new int[] { 4, 5, 6, 4, 4 }, 2)]
    [InlineData(new int[] { 6, 7, 8, 9 }, 0)]
    public void FindMinimumTime(int[] nums, int expected)
    {
        var actual = _3396_MinimumOperations.MinimumOperations(nums);
        Assert.Equal(expected, actual);
    }
}
