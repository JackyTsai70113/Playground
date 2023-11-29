namespace playground.UnitTest;

public class GameOfLifeTest_0289
{
    [Theory]
    [InlineData("[[0,1,0],[0,0,1],[1,1,1],[0,0,0]]", "[[0,0,0],[1,0,1],[0,1,1],[0,1,0]]")]
    [InlineData("[[1,1],[1,0]]", "[[1,1],[1,1]]")]
    public void GameOfLife(string A, string expected)
    {
        var actual = A.To2dArr();
        GameOfLife_0289.GameOfLife(actual);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
