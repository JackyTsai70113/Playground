using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2536_RangeAddQueriesTest
{
    [Theory]
    [InlineData(3, "[[1,1,2,2],[0,0,1,1]]", "[[1,1,0],[1,2,1],[0,1,1]]")]
    [InlineData(2, "[[0,0,1,1]]", "[[1,1],[1,1]]")]
    public void RangeAddQueries(int n, string queries, string expected)
    {
        var actual = _2536_RangeAddQueries.RangeAddQueries(n, queries.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
