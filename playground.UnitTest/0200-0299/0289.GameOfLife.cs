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
        var expectedArr = expected.To2dArr();
        Assert.Equal(expectedArr.Length, actual.Length);
        for (int i = 0; i < expectedArr.Length; i++)
        {
            Assert.True(Enumerable.SequenceEqual(expectedArr[i], actual[i]));
        }
    }
}
