using playground._0600_0699;

namespace playground.UnitTest._0600_0699;

public class _0684_FindRedundantConnectionTest
{
    [Theory]
    [InlineData("[[1,2],[1,3],[2,3]]", new int[] { 2, 3 })]
    [InlineData("[[1,2],[2,3],[3,4],[1,4],[1,5]]", new int[] { 1, 4 })]
    public void FindRedundantConnection(string edges, int[] expected)
    {
        var actual = _0684_FindRedundantConnection.FindRedundantConnection(edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
