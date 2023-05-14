using playground.DynamicPrograming;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DynamicPrograming;

public class MinIncrementsTest
{
    [Theory]
    [InlineData(7, "[1,5,2,2,3,3,1]", 6)]
    [InlineData(3, "[5,3,3]", 0)]
    public void MinIncrements(int n, string a, int expected)
    {
        var cost = a.ToArr<int>();

        int actual = MinIncrementsClass.MinIncrements(n, cost);

        Assert.Equal(expected, actual);
    }
}
