using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3300_MinElementTest
{
    [Theory]
    [InlineData(new int[] { 10, 12, 13, 14 }, 1)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 1)]
    [InlineData(new int[] { 999, 19, 199 }, 10)]
    public void MinElement(int[] nums, int expected)
    {
        var actual = _3300_MinElement.MinElement(nums);
        Assert.Equal(expected, actual);
    }
}
