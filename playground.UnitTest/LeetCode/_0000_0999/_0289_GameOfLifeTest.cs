using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0289_GameOfLifeTest
{
    [Theory]
    [InlineData("[[0,1,0],[0,0,1],[1,1,1],[0,0,0]]", "[[0,0,0],[1,0,1],[0,1,1],[0,1,0]]")]
    [InlineData("[[1,1],[1,0]]", "[[1,1],[1,1]]")]
    public void GameOfLife(string A, string expected)
    {
        var actual = A.To2dArr();
        _0289_GameOfLife.GameOfLife(actual);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
