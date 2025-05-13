using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3354_CountValidSelectionsTest
{
    [Theory]
    [InlineData(new int[] { 1, 0, 2 }, 1)]
    [InlineData(new int[] { 2, 0, 1 }, 1)]
    [InlineData(new int[] { 1, 0, 2, 0, 3 }, 2)]
    [InlineData(new int[] { 2, 3, 4, 0, 4, 1, 0 }, 0)]
    [InlineData(new int[] { 1, 0, 2, 0, 0, 3 }, 4)]
    [InlineData(new int[] { 16, 13, 10, 0, 0, 0, 10, 6, 7, 8, 7 }, 3)]
    public void CountValidSelections(int[] nums, int expected)
    {
        var actual = _3354_CountValidSelections.CountValidSelections(nums);
        Assert.Equal(expected, actual);
    }
}
