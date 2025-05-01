using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0239_MaxSlidingWindowTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3, new int[] { 3, 3, 5, 5, 6, 7 })]
    [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
    public void MaxSlidingWindow(int[] nums, int k, int[] expected)
    {
        var actual = _0239_MaxSlidingWindow.MaxSlidingWindow(nums, k);
        Assert.Equal(expected, actual);
    }
}
