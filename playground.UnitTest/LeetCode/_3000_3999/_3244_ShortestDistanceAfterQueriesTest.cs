namespace playground.UnitTest.LeetCode._3000_3999;

public class _3244_ShortestDistanceAfterQueriesTest
{
    [Theory]
    [InlineData(5, "[[2,4],[0,2],[0,4]]", new int[] { 3, 2, 1 })]
    [InlineData(7, "[[2,4],[0,6],[1,5]]", new int[] { 5, 1, 1 })]
    [InlineData(4, "[[0,3],[0,2]]", new int[] { 1, 1 })]
    public void ShortestDistanceAfterQueries(int n, string queries, int[] expected)
    {
        var actual = _3244_ShortestDistanceAfterQueries.ShortestDistanceAfterQueries(n, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
