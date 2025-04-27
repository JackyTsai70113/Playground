using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3532_PathExistenceQueriesTest
{
    [Theory]
    [InlineData(2, new int[] { 1, 3 }, 1, "[[0,0],[0,1]]", new bool[] { true, false })]
    [InlineData(4, new int[] { 2, 5, 6, 8 }, 2, "[[0,1],[0,2],[1,3],[2,3]]", new bool[] { false, false, true, true })]
    public void PathExistenceQueries(int n, int[] nums, int maxDiff, string queries, bool[] expected)
    {
        var actual = _3532_PathExistenceQueries.PathExistenceQueries(n, nums, maxDiff, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
