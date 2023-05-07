using playground.Greedy;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Greedy;

public class MinSwapsCouplesTest
{
    [Theory]
    // [InlineData("[0,2,1,3]", 1)]
    // [InlineData("[3,2,0,1]", 0)]
    [InlineData("[2,0,5,4,3,1]", 1)]
    public void MinSwapsCouples(string str, int expected)
    {
        var seats = str.ToArr<int>();
        var actual = MinSwapsCouplesClass.MinSwapsCouples(seats);
        Assert.Equal(expected, actual);
    }
}
