using playground.Stacks;

namespace playground.UnitTest.Stacks;

public class SurvivedRobotsHealthsTest
{
    [Theory]
    [InlineData(new int[] { 3, 5, 2, 6 }, new int[] { 10, 10, 15, 12 }, "RLRL", new int[] { 14 })]
    [InlineData(new int[] { 1, 2, 5, 6 }, new int[] { 10, 10, 12, 12 }, "RLRL", new int[] { })]
    [InlineData(new int[] { 4, 6 }, new int[] { 601, 973 }, "RL", new int[] { 972 })]
    public void SurvivedRobotsHealths(int[] positions, int[] healths, string directions, int[] expected)
    {
        var actual = SurvivedRobotsHealthsClass.SurvivedRobotsHealths(positions, healths, directions);
        Assert.Equal(expected, actual);
    }
}
