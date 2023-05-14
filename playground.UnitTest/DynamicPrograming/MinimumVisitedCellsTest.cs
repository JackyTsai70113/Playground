using playground.DynamicPrograming;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DynamicPrograming;

public class MinimumVisitedCellsTest
{
    [Theory]
    [InlineData("[[3,4,2,1],[4,2,3,1],[2,1,0,0],[2,4,0,0]]", 4)]
    [InlineData("[[3,4,2,1],[4,2,1,1],[2,1,1,0],[3,4,1,0]]", 3)]
    [InlineData("[[2,1,0],[1,0,0]]", -1)]
    public void MinimumVisitedCells(string a, int expected)
    {
        int[][] grid = a.To2dArr<int>();

        int actual = MinimumVisitedCellsClass.MinimumVisitedCells(grid);

        Assert.Equal(expected, actual);
    }
}
