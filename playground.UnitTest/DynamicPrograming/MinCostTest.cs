using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MinCostTest
{
    [Theory]
    [InlineData(7, new int[] { 1, 3, 4, 5 }, 16)]
    [InlineData(9, new int[] { 5, 6, 1, 4, 2 }, 22)]
    public void MinCost(int n, int[] cuts, int expected)
    {
        int actual = MinCostClass.MinCost(n, cuts);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(7, new int[] { 1, 3, 4, 5 }, 16)]
    [InlineData(9, new int[] { 5, 6, 1, 4, 2 }, 22)]
    public void MinCost_2(int n, int[] cuts, int expected)
    {
        int actual = MinCostClass.MinCost_2(n, cuts);
        Assert.Equal(expected, actual);
    }
}
