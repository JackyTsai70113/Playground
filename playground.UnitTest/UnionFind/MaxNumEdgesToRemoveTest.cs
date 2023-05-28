using playground.UnionFinds;

namespace playground.UnitTest.UnionFind;

public class MaxNumEdgesToRemoveTest
{
    [Theory]
    [InlineData(4, "[[3,1,2],[3,2,3],[1,1,3],[1,2,4],[1,1,2],[2,3,4]]", 2)]
    [InlineData(13, "[[1,1,2],[2,1,3],[3,2,4],[3,2,5],[1,2,6],[3,6,7],[3,7,8],[3,6,9],[3,4,10],[2,3,11],[1,5,12],[3,3,13],[2,1,10],[2,6,11],[3,5,13],[1,9,12],[1,6,8],[3,6,13],[2,1,4],[1,1,13],[2,9,10],[2,1,6],[2,10,13],[2,2,9],[3,4,12],[2,4,7],[1,1,10],[1,3,7],[1,7,11],[3,3,12],[2,4,8],[3,8,9],[1,9,13]]", 19)]
    [InlineData(4, "[[3,2,3],[1,1,2],[2,3,4]]", -1)]
    public void MaxNumEdgesToRemove(int n, string edges, int expected)
    {
        var actual = MaxNumEdgesToRemoveClass.MaxNumEdgesToRemove(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
