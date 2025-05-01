using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2924_FindChampionTest
{
    [Theory]
    [InlineData(3, "[[0,1],[1,2]]", 0)]
    [InlineData(4, "[[0,2],[1,3],[1,2]]", -1)]
    public void FindChampion(int n, string edgesString, int expected)
    {
        var edges = edgesString.To2dArr();
        var actual = _2924_FindChampion.FindChampion(n, edges);
        Assert.Equal(expected, actual);
    }
}
