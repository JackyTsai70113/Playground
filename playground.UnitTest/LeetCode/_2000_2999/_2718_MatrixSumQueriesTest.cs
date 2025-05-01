using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2718_MatrixSumQueriesTest
{
    [Theory]
    [InlineData(3, "[[0,0,1],[1,2,2],[0,2,3],[1,0,4]]", 23)]
    [InlineData(3, "[[0,0,4],[0,1,2],[1,0,1],[0,2,3],[1,2,1]]", 17)]
    public void MatrixSumQueries(int n, string qs, long expected)
    {
        var actual = _2718_MatrixSumQueries.MatrixSumQueries(n, qs.To2dArr());
        Assert.Equal(expected, actual);
    }
}
