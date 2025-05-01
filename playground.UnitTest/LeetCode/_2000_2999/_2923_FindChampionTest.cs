using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2923_FindChampionTest
{
    [Theory]
    [InlineData("[[0,1],[0,0]]", 0)]
    [InlineData("[[0,0,1],[1,0,1],[0,0,0]]", 1)]
    public void FindChampion(string gridString, int expected)
    {
        var grid = gridString.To2dArr();
        var actual = _2923_FindChampion.FindChampion(grid);
        Assert.Equal(expected, actual);
    }
}
