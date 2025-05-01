using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2925_MaximumScoreAfterOperationsTest
{
    [Theory]
    [InlineData("[[0,1],[0,2],[0,3],[2,4],[4,5]]", "[5,2,5,2,1,1]", 11)]
    [InlineData("[[0,1],[0,2],[1,3],[1,4],[2,5],[2,6]]", "[20,10,9,7,4,3,5]", 40)]
    public void MaximumScoreAfterOperations(string edgesString, string valuesString, long expected)
    {
        var edges = edgesString.To2dArr();
        var values = valuesString.ToArr();
        var actual = _2925_MaximumScoreAfterOperations.MaximumScoreAfterOperations(edges, values);
        Assert.Equal(expected, actual);
    }
}
