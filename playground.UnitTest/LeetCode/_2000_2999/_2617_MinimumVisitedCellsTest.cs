using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2617_MinimumVisitedCellsTest
{
    [Theory]
    [InlineData("[[2,1,0],[1,0,0]]", -1)]
    [InlineData("[[2,0,0],[0,2,0],[0,0,0]]", -1)]
    [InlineData("[[3,4,2,1],[4,2,3,1],[2,1,0,0],[2,4,0,0]]", 4)]
    [InlineData("[[3,4,2,1],[4,2,1,1],[2,1,1,0],[3,4,1,0]]", 3)]
    [InlineData($@"[[2,1,1,1,1,2,2,1,0],
                    [0,0,1,2,0,0,0,2,2],
                    [2,0,2,2,1,2,1,0,0]]", 9)]
    [InlineData("[[2,1,1,1,0],[0,0,0,2,1],[3,0,0,0,0]]", 6)]
    public void MinimumVisitedCells(string grid, int expected)
    {
        int actual = _2617_MinimumVisitedCells.MinimumVisitedCells(grid.To2dArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[[3,4,2,1],[4,2,3,1],[2,1,0,0],[2,4,0,0]]", 4)]
    [InlineData("[[2,1,1,1,0],[0,0,0,2,1],[3,0,0,0,0]]", -1)] // 這是錯誤
    public void MinimumVisitedCells_Greedy(string grid, int expected)
    {
        int actual = _2617_MinimumVisitedCells.MinimumVisitedCells_Greedy(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
