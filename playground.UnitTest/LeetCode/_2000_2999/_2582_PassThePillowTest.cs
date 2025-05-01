using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2582_PassThePillowTest
{
    [Theory]
    [InlineData(4, 5, 2)]
    [InlineData(3, 2, 3)]
    public void PassThePillow
(int n, int time, int expected)
    {
        var actual = _2582_PassThePillow.PassThePillow(n, time);
        Assert.Equal(expected, actual);
    }
}
