namespace playground.UnitTest;

public class _3249_CountGoodNodesTest
{
    [Theory]
    [InlineData("[[0,1],[1,2],[1,3],[0,4]]", 4)]
    [InlineData("[[0,1],[0,2],[1,3],[1,4],[2,5],[2,6]]", 7)]
    [InlineData("[[0,1],[1,2],[2,3],[3,4],[0,5],[1,6],[2,7],[3,8]]", 6)]
    [InlineData("[[0,1],[1,2],[1,3],[1,4],[0,5],[5,6],[6,7],[7,8],[0,9],[9,10],[9,12],[10,11]]", 12)]
    public void CountGoodNodes(string edges, int expected)
    {
        var actual = _3249_CountGoodNodes.CountGoodNodes(edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
