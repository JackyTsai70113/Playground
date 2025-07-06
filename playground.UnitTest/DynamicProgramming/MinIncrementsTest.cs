using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class MinIncrementsTest
{
    [Theory]
    [InlineData(7, new int[] { 1, 5, 2, 2, 3, 3, 1 }, 6)]
    [InlineData(3, new int[] { 5, 3, 3 }, 0)]
    public void MinIncrements(int n, int[] cost, int expected)
    {
        int actual = MinIncrementsClass.MinIncrements(n, cost);
        Assert.Equal(expected, actual);
    }
}
