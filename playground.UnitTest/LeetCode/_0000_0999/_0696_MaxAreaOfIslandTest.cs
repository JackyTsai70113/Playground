using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0695_MaxAreaOfIslandTest
{
    [Theory]
    [InlineData("[[0,0,1,0,0],[0,1,1,1,0],[0,0,0,1,0],[0,1,0,0,0],[1,1,0,1,1]]", 5)]
    [InlineData("[[0,0,0,0,0],[0,1,1,1,0],[0,0,0,1,0],[0,1,0,0,0],[1,1,0,1,1]]", 4)]
    [InlineData("[[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]", 0)]
    public void MaxAreaOfIslandTest(string grid, int expected)
    {
        var actual = _0695_MaxAreaOfIsland.MaxAreaOfIsland(grid.To2dArr<int>());
        Assert.Equal(expected, actual);
    }
}
