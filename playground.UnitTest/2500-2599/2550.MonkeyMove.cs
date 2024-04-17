namespace playground.UnitTest;

public class MonkeyMoveTest2550
{
    [Theory]
    [InlineData(3, 6)]
    [InlineData(4, 14)]
    [InlineData(1000000000, 140624999)]
    public void MonkeyMove(int n, int expected)
    {
        var actual = MonkeyMove2550.MonkeyMove(n);
        Assert.Equal(expected, actual);
    }
}
