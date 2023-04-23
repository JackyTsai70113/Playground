using playground.Array;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Array;

public class OrangesRottingTest
{
    [Theory]
    [InlineData("[[2,1,1],[1,1,0],[0,1,1]]", 4)]
    [InlineData("[[2,1,1],[0,1,1],[1,0,1]]", -1)]
    [InlineData("[[0,2]]]", 0)]
    public void OrangesRotting(string arr, int expected)
    {
        int[][] grid = arr.To2dArr<int>();

        var actual = OrangesRottingClass.OrangesRotting(grid);

        Assert.Equal(expected, actual);
    }
}
