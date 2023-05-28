using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

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
