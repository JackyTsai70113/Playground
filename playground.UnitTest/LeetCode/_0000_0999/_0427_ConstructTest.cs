using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0427_ConstructTest
{
    [Theory]
    [InlineData("[[0,1],[1,0]]", "[[0,1],[1,0],[1,1],[1,1],[1,0]]")]
    [InlineData("[[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0],[1,1,1,1,0,0,0,0]]", "[[0,1],[1,1],[0,1],[1,1],[1,0],null,null,null,null,[1,0],[1,0],[1,1],[1,1]]")]
    public void Construct(string grid, string expected)
    {
        var actual = _0427_Construct.Construct(grid.To2dArr());
        Assert.Equal(expected, actual.ToString());
    }
}
