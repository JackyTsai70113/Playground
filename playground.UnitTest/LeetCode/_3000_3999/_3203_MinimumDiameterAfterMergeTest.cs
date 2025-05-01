namespace playground.UnitTest;

public class _3203_MinimumDiameterAfterMergeTest
{
    [Theory]
    [InlineData("[]", "[]", 1)]
    [InlineData("[[0,1],[0,2],[0,3]]", "[[0,1]]", 3)]
    [InlineData("[[0,1],[0,2],[0,3],[2,4],[2,5],[3,6],[2,7]]", "[[0,1],[0,2],[0,3],[2,4],[2,5],[3,6],[2,7]]", 5)]
    [InlineData("[[0,1],[2,0],[3,2],[3,6],[8,7],[4,8],[5,4],[3,5],[3,9]]", "[[0,1],[0,2],[0,3]]", 7)]
    public void MinimumDiameterAfterMerge(string edges1, string edges2, int expected)
    {
        var actual = _3203_MinimumDiameterAfterMerge.MinimumDiameterAfterMerge(edges1.To2dArr(), edges2.To2dArr());
        Assert.Equal(expected, actual);
    }
}
