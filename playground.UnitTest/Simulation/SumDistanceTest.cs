using playground.Simulation;

namespace playground.UnitTest.Simulation;

public class SumDistanceTest
{
    [Theory]
    [InlineData(new int[] { -2, 0, 2 }, "RLL", 3, 8)]
    [InlineData(new int[] { 1, 0 }, "RL", 2, 5)]
    public void SumDistance(int[] nums, string s, int d, int expected)
    {
        var actual = SumDistanceClass.SumDistance(nums, s, d);
        Assert.Equal(expected, actual);
    }
}
