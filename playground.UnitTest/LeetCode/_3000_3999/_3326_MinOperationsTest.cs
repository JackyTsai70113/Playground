using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3326_MinOperationsTest
{
    [Theory]
    [InlineData(new int[] { 25, 7 }, 1)]
    [InlineData(new int[] { 7, 7, 6 }, -1)]
    [InlineData(new int[] { 1, 1, 1, 1 }, 0)]
    [InlineData(new int[] { 9, 2 }, -1)]
    [InlineData(new int[] { 105, 11 }, 1)]
    [InlineData(new int[] { 9, 27, 81, 27, 3 }, 4)]
    public void MinOperations(int[] nums, int expected)
    {
        var actual = _3326_MinOperations.MinOperations(nums);
        Assert.Equal(expected, actual);
    }
}
