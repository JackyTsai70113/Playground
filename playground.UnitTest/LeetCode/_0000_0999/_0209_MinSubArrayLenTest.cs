using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0209_MinSubArrayLenTest
{
    [Theory]
    [InlineData(7, new int[] { 2, 3, 1, 2, 4, 3 }, 2)]
    [InlineData(4, new int[] { 1, 4, 4 }, 1)]
    [InlineData(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
    public void MinSubArrayLen(int target, int[] nums, int expected)
    {
        var actual = _0209_MinSubArrayLen.MinSubArrayLen(target, nums);
        Assert.Equal(expected, actual);
    }
}
