namespace playground.UnitTest;

public class FindChampionTest_2924
{
    [Theory]
    [InlineData(3, "[[0,1],[1,2]]", 0)]
    [InlineData(4, "[[0,2],[1,3],[1,2]]", -1)]
    public void FindChampion(int n, string edgesString, int expected)
    {
        var edges = edgesString.To2dArr();
        var actual = FindChampion_2924.FindChampion(n, edges);
        Assert.Equal(expected, actual);
    }
}
