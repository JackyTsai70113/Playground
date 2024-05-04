namespace playground.UnitTest;

public class SumDistanceTest2731
{
    [Theory]
    [InlineData(new int[] { -2, 0, 2 }, "RLL", 3, 8)]
    [InlineData(new int[] { 1, 0 }, "RL", 2, 5)]
    [InlineData(new int[] { -2000000000, 2000000000 }, "LR", 1000000000, 999999965)]
    public void SumDistance(int[] nums, string s, int d, int expected)
    {
        var actual = SumDistance2731.SumDistance(nums, s, d);
        Assert.Equal(expected, actual);
    }
}
