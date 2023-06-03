using playground.PrefixSum;

namespace playground.UnitTest.PrefixSum;

public class RangeAddQueriesTest
{
    [Theory]
    [InlineData(3, "[[1,1,2,2],[0,0,1,1]]", "[[1,1,0],[1,2,1],[0,1,1]]")]
    [InlineData(2, "[[0,0,1,1]]", "[[1,1],[1,1]]")]
    public void RangeAddQueries(int n, string queries, string expected)
    {
        var actual = RangeAddQueriesClass.RangeAddQueries(n, queries.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
