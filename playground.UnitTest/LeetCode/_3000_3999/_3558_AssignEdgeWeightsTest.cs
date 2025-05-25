using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3558_AssignEdgeWeightsTest
{
    [Theory]
    [InlineData("[[1,2]]", 1)]
    [InlineData("[[1,2],[1,3],[3,4],[3,5]]", 2)]
    public void AssignEdgeWeights(string edges, int expected)
    {
        var result = _3558_AssignEdgeWeights.AssignEdgeWeights(edges.To2dArr());
        Assert.Equal(expected, result);
    }
}
