namespace playground.UnitTest;

public class ShortestDistanceAfterQueriesTest3243
{
    [Theory]
    [InlineData(5, "[[2,4],[0,2],[0,4]]", new int[] { 3, 2, 1 })]
    [InlineData(4, "[[0,3],[0,2]]", new int[] { 1, 1 })]
    public void ShortestDistanceAfterQueries(int n, string queries, int[] expected)
    {
        var actual = ShortestDistanceAfterQueries3243.ShortestDistanceAfterQueries(n, queries.To2dArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, "[[2,4],[0,2],[0,4]]", new int[] { 3, 2, 1 })]
    [InlineData(4, "[[0,3],[0,2]]", new int[] { 1, 1 })]
    public void ShortestDistanceAfterQueries2(int n, string queries, int[] expected)
    {
        var actual = ShortestDistanceAfterQueries3243.ShortestDistanceAfterQueries2(n, queries.To2dArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, "[[2,4],[0,2],[0,4]]", new int[] { 3, 2, 1 })]
    [InlineData(4, "[[0,3],[0,2]]", new int[] { 1, 1 })]
    public void ShortestDistanceAfterQueries3(int n, string queries, int[] expected)
    {
        var actual = ShortestDistanceAfterQueries3243.ShortestDistanceAfterQueries3(n, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
