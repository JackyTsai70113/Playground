using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2550_MonkeyMoveTest
{
    [Theory]
    [InlineData(3, 6)]
    [InlineData(4, 14)]
    [InlineData(1000000000, 140624999)]
    public void MonkeyMove(int n, int expected)
    {
        var actual = _2550_MonkeyMove.MonkeyMove(n);
        Assert.Equal(expected, actual);
    }
}
