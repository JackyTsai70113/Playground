using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3547_MaxScoreTest
{
    [Theory]
    [InlineData(7, "[[0,1],[1,2],[2,0],[3,4],[4,5],[5,6]]", 130)]
    [InlineData(6, "[[0,3],[4,5],[2,0],[1,3],[2,4],[1,5]]", 82)]
    [InlineData(8, "[[0,1],[1,2],[2,3],[3,4],[4,0]]", 183)]
    [InlineData(8, "[[4,7],[2,1]]", 86)]
    [InlineData(20, "[[12,9],[1,9],[7,1],[5,7],[0,13],[6,0]]", 1756)]
    public void Test(int n, string edges, long expected)
    {
        var edgeList = edges.To2dArr();
        var result = _3547_MaxScore.MaxScore(n, edgeList);
        Assert.Equal(expected, result);
    }
}
