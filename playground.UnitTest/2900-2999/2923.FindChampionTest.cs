namespace playground.UnitTest;

public class FindChampionTest_2923
{
    [Theory]
    [InlineData("[[0,1],[0,0]]", 0)]
    [InlineData("[[0,0,1],[1,0,1],[0,0,0]]", 1)]
    public void FindChampion(string gridString, int expected)
    {
        var grid = gridString.To2dArr();
        var actual = FindChampion_2923.FindChampion(grid);
        Assert.Equal(expected, actual);
    }
}
