namespace playground.UnitTest;

public class XorQueriesTest1310
{
    [Theory]
    [InlineData(new int[] { 1, 3, 4, 8 }, "[[0,1],[1,2],[0,3],[3,3]]", new int[] { 2, 7, 14, 8 })]
    [InlineData(new int[] { 4, 8, 2, 10 }, "[[2,3],[1,3],[0,0],[0,3]]", new int[] { 8, 0, 4, 4 })]
    public void XorQueries(int[] arr, string queries, int[] expected)
    {
        var actual = new XorQueries1310().XorQueries(arr, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
