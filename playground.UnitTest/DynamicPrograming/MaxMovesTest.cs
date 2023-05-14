using playground.DynamicPrograming;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DynamicPrograming;

public class MaxMovesTest
{
    [Theory]
    [InlineData("[[2,4,3,5],[5,4,9,3],[3,4,2,11],[10,9,13,15]]", 3)]
    [InlineData("[[3,2,4],[2,1,9],[1,1,7]]", 0)]
    public void MaxMoves(string g, int expected)
    {
        var actual = MaxMovesClass.MaxMoves(g.To2dArr<int>());
        Assert.Equal(actual, expected);
    }
}
