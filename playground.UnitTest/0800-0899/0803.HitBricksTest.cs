using playground.UnionFinds;

namespace playground.UnitTest.UnionFinds;

public class HitBricksTest
{
    [Theory]
    [InlineData("[[1,0,0,0],[1,1,1,0]]", "[[1,0]]", new int[] { 2 })]
    [InlineData("[[1,0,0,0],[1,1,0,0]]", "[[1,1],[1,0]]", new int[] { 0, 0 })]
    [InlineData("[[1],[1],[1],[1],[1]]", "[[3,0],[4,0],[1,0],[2,0],[0,0]]", new int[] { 1, 0, 1, 0, 0 })]
    [InlineData("[[1],[1],[1],[1],[0]]", "[[3,0],[4,0],[1,0],[2,0],[0,0]]", new int[] { 0, 0, 1, 0, 0 })]
    [InlineData("[[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1],[1]]", "[[5,0],[6,0],[3,0],[4,0],[7,0]]", new int[] { 6, 0, 1, 0, 0 })]
    public void MaxNumEdgesToRemove(string grid, string hits, int[] expected)
    {
        var actual = HitBricks0803.HitBricks(grid.To2dArr(), hits.To2dArr());
        Assert.Equal(expected, actual);
    }
}
