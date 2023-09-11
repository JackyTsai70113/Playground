using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MinimumMovesTest
{
    [Theory]
    [InlineData("[[1,1,0],[1,1,1],[1,2,1]]", 3)]
    [InlineData("[[1,3,0],[1,0,0],[1,0,3]]", 4)]
    [InlineData("[[6,1,0],[1,1,0],[0,0,0]]", 14)]
    [InlineData("[[3,1,0],[1,1,0],[2,1,0]]", 7)]
    [InlineData("[[3,2,0],[0,1,0],[0,3,0]]", 7)]
    public void MinimumMoves(string A, int expected)
    {
        var actual = MinimumMovesClass.MinimumMoves(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
