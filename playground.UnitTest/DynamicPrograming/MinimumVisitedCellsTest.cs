using playground.DynamicPrograming;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DynamicPrograming;

public class MinimumVisitedCellsTest
{
    [Theory]
    [InlineData(new int[] { 3, 4, 2, 1, 4, 2, 3, 1, 2, 1, 0, 0, 2, 4, 0, 0 }, 4, 4)]
    [InlineData(new int[] { 2, 1, 0, 1, 0, 0 }, 3, -1)]
    public void MinimumVisitedCells(int[] array, int rowCount, int expected)
    {
        int[][] grid = array.To2dArray(rowCount);

        int actual = MinimumVisitedCellsClass.MinimumVisitedCells(grid);

        Assert.Equal(expected, actual);
    }
}
