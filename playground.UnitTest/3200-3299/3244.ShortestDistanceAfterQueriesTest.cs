namespace playground.UnitTest;

public class ShortestDistanceAfterQueriesTest3244
{
    [Theory]
    [InlineData(5, "[[2,4],[0,2],[0,4]]", new int[] { 3, 2, 1 })]
    [InlineData(7, "[[2,4],[0,6],[1,5]]", new int[] { 5, 1, 1 })]
    [InlineData(4, "[[0,3],[0,2]]", new int[] { 1, 1 })]
    public void ShortestDistanceAfterQueries(int n, string queries, int[] expected)
    {
        var actual = ShortestDistanceAfterQueries3244.ShortestDistanceAfterQueries(n, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
