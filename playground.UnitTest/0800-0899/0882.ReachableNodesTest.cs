namespace playground.UnitTest;

public class ReachableNodesTest0882
{
    [Theory]
    [InlineData("[[0,1,10],[0,2,1],[1,2,2]]", 6, 3, 13)]
    [InlineData("[[0,1,4],[1,2,6],[0,2,8],[1,3,1]]", 10, 4, 23)]
    [InlineData("[[1,2,4],[1,4,5],[1,3,1],[2,3,4],[3,4,5]]", 17, 5, 1)]
    public void ReachableNodes(string edges, int maxMoves, int n, int expected)
    {
        var actual = ReachableNodes0882.ReachableNodes(edges.To2dArr(), maxMoves, n);
        Assert.Equal(expected, actual);
    }
}
