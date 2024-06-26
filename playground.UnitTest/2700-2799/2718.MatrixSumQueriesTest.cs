namespace playground.UnitTest;

public class MatrixSumQueriesTest2718
{
    [Theory]
    [InlineData(3, "[[0,0,1],[1,2,2],[0,2,3],[1,0,4]]", 23)]
    [InlineData(3, "[[0,0,4],[0,1,2],[1,0,1],[0,2,3],[1,2,1]]", 17)]
    public void MatrixSumQueries(int n, string qs, long expected)
    {
        var actual = MatrixSumQueries2718.MatrixSumQueries(n, qs.To2dArr());
        Assert.Equal(expected, actual);
    }
}
