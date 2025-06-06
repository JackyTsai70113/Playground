using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0913_CatMouseGameTest
{
    [Theory]
    [InlineData("[[2,5],[3],[0,4,5],[1,4,5],[2,3],[0,2,3]]", 0)]
    [InlineData("[[5,6],[3],[5,6],[1,4,5],[3,6],[0,2,3],[0,2,4]]", 0)]
    [InlineData("[[1,3],[0],[3],[0,2]]", 1)]
    [InlineData("[[2],[2],[0,1]]", 2)]
    [InlineData("[[4],[3],[5],[1,4],[0,3,5],[2,4]]", 2)]
    [InlineData("[[4],[3],[6],[1,4],[0,3,5],[4,6],[2,5]]", 1)]
    public void CatMouseGame(string graph, int expected)
    {
        var actual = _0913_CatMouseGame.CatMouseGame(graph.To2dArr());
        Assert.Equal(expected, actual);
    }
}
