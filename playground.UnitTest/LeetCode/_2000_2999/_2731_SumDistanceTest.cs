using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2731_SumDistanceTest
{
    [Theory]
    [InlineData(new int[] { -2, 0, 2 }, "RLL", 3, 8)]
    [InlineData(new int[] { 1, 0 }, "RL", 2, 5)]
    [InlineData(new int[] { -2000000000, 2000000000 }, "LR", 1000000000, 999999965)]
    public void SumDistance(int[] nums, string s, int d, int expected)
    {
        var actual = _2731_SumDistance.SumDistance(nums, s, d);
        Assert.Equal(expected, actual);
    }
}
