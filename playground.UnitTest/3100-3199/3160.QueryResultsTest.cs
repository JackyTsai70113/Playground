namespace playground.UnitTest;

public class QueryResultsTest3160
{
    [Theory]
    [InlineData(4, "[[1,4],[2,5],[1,3],[3,4]]", new int[] { 1, 2, 2, 3 })]
    [InlineData(4, "[[0,1],[1,2],[2,2],[3,4],[4,5]]", new int[] { 1, 2, 2, 3, 4 })]
    public void QueryResults(int limit, string queries, int[] expected)
    {
        var actual = QueryResults3160.QueryResults(limit, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
