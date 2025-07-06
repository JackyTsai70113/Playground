using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3607_ProcessQueriesTest
{
    [Theory]
    [InlineData(5, "[[2,3],[3,4],[4,5],[1,2]]", "[[1,3],[2,1],[1,1],[2,2],[1,2]]", new[] { 3, 2, 3 })]
    [InlineData(5, "[[1,2],[2,3],[3,4],[4,5]]", "[[1,3],[2,1],[1,1],[2,2],[1,2]]", new[] { 3, 2, 3 })]
    [InlineData(3, "[[3,2],[1,3],[2,1]]", "[[2,1]]", new int[0])]
    [InlineData(3, "[]", "[[1,1],[2,1],[1,1]]", new[] { 1, -1 })]
    public void ProcessQueries(int c, string connections, string queries, int[] expected)
    {
        // Act
        var actual = _3607_ProcessQueries.ProcessQueries(c, connections.To2dArr(), queries.To2dArr());

        // Assert
        Assert.Equal(expected, actual);
    }
}