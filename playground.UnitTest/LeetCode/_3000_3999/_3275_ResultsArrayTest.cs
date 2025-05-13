namespace playground.UnitTest.LeetCode._3000_3999;

public class _3275_ResultsArrayTest
{
    [Theory]
    [InlineData("[[1,2],[3,4],[2,3],[-3,0]]", 2, new int[] { -1, 7, 5, 3 })]
    [InlineData("[[5,5],[4,4],[3,3]]", 1, new int[] { 10, 8, 6 })]
    public void ResultsArray(string queries, int k, int[] expected)
    {
        var actual = _3275_ResultsArray.ResultsArray(queries.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
