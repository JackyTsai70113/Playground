using System.Text.Json;

namespace playground.UnitTest;

public class FindChampionTest
{
    [Theory]
    [InlineData("[[0,1],[0,0]]", 0)]
    [InlineData("[[0,0,1],[1,0,1],[0,0,0]]", 1)]
    public void FindChampion(string gridString, int expected)
    {
        var grid = gridString.To2dArr();
        var actual = new FindChampionClass().FindChampion(grid);
        Assert.Equal(expected, actual);
    }
}
