using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2751_SurvivedRobotsHealthsTest
{
    [Theory]
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 2, 17, 9, 15, 10 }, "RRRRR", new int[] { 2, 17, 9, 15, 10 })]
    [InlineData(new int[] { 3, 5, 2, 6 }, new int[] { 10, 10, 15, 12 }, "RLRL", new int[] { 14 })]
    [InlineData(new int[] { 1, 2, 5, 6 }, new int[] { 10, 10, 11, 11 }, "RLRL", new int[] { })]
    [InlineData(new int[] { 1, 40 }, new int[] { 10, 11 }, "RL", new int[] { 10 })]
    [InlineData(new int[] { 1, 40 }, new int[] { 10, 11 }, "RR", new int[] { 10, 11 })]
    [InlineData(new int[] { 1, 40 }, new int[] { 10, 11 }, "LL", new int[] { 10, 11 })]
    [InlineData(new int[] { 1, 40 }, new int[] { 10, 11 }, "LR", new int[] { 10, 11 })]
    public void SurvivedRobotsHealths(int[] positions, int[] healths, string directions, IList<int> expected)
    {
        var actual = _2751_SurvivedRobotsHealths.SurvivedRobotsHealths(positions, healths, directions);
        Assert.Equal(expected, actual);
    }
}
