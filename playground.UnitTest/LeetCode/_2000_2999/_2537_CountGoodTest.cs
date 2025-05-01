using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2537_CountGoodTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 10, 1)]
    [InlineData(new int[] { 3, 1, 4, 3, 2, 2, 4 }, 2, 4)]
    [InlineData(new int[] { 2, 3, 1, 3, 2, 3, 3, 3, 1, 1, 3, 2, 2, 2 }, 18, 9)]
    public void CountGood(int[] nums, int k, int expected)
    {
        var actual = _2537_CountGood.CountGood(nums, k);
        Assert.Equal(expected, actual);
    }
}
