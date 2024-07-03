namespace playground.UnitTest;

public class GetAncestorsTest2192
{
    [Theory]
    [InlineData(8, "[[0,3],[0,4],[1,3],[2,4],[2,7],[3,5],[3,6],[3,7],[4,6]]", "[[],[],[],[0,1],[0,2],[0,1,3],[0,1,2,3,4],[0,1,2,3]]")]
    [InlineData(5, "[[0,1],[0,2],[0,3],[0,4],[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]", "[[],[0],[0,1],[0,1,2],[0,1,2,3]]")]
    public void GetAncestors(int n, string edges, string expected)
    {
        var actual = GetAncestors2192.GetAncestors(n, edges.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
