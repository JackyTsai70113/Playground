namespace playground.UnitTest;

public class FinalPositionOfSnakeTest3248
{
    [Theory]
    [InlineData(2, new string[]{"RIGHT","LEFT","DOWN","UP"}, 0)]
    [InlineData(2, new string[]{"RIGHT","DOWN"}, 3)]
    [InlineData(3,new string[] { "DOWN","RIGHT","UP" }, 1)]
    public void FinalPositionOfSnake(int n, string[] commands, int expected)
    {
        var actual = FinalPositionOfSnake3248.FinalPositionOfSnake(n, commands);
        Assert.Equal(expected, actual);
    }
}