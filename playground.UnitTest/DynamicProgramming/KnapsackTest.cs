using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class KnapsackTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 2 }, new int[] { 1, 2, 3, 2 }, 3)]
    [InlineData(new int[] { 2, 3, 4, 2 }, new int[] { 1, 1, 1, 1 }, 4)]
    public void PaintWalls(int[] cost, int[] time, int expected)
    {
        int actual = Knapsack.PaintWalls(cost, time);
        Assert.Equal(expected, actual);
    }
}
