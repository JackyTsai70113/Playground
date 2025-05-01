using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2940_LeftmostBuildingQueriesTest_cs
{
    [Theory]
    [InlineData(new int[] { 6, 4, 8, 5, 2, 7 }, "[[0,1],[0,3],[2,4],[3,4],[2,2]]", new int[] { 2, 5, -1, 5, 2 })]
    [InlineData(new int[] { 5, 3, 8, 2, 6, 1, 4, 6 }, "[[0,7],[3,5],[5,2],[3,0],[1,6]]", new int[] { 7, 6, -1, 4, 6 })]
    public void LeftmostBuildingQueries(int[] heights, string queries, int[] expected)
    {
        var actual = _2940_LeftmostBuildingQueries_cs.LeftmostBuildingQueries(heights, queries.To2dArr());
        Assert.True(Enumerable.SequenceEqual(expected, actual));
    }
}
