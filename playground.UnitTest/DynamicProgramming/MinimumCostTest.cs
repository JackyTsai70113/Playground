using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class MinimumCostTest
{
    [Theory]
    [InlineData("0011", 2)]
    [InlineData("010101", 9)]
    public void NumberOfArrays(string s, int expected)
    {
        var actual = MinimumCostClass.MinimumCost(s);
        Assert.Equal(expected, actual);
    }
}
