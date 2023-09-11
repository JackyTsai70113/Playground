using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class IsReachableAtTimeTest
{
    [Theory]
    [InlineData(1, 1, 1, 1, 2, true)]
    [InlineData(1, 1, 1, 1, 1, false)]
    [InlineData(1, 1, 1, 1, 0, true)]
    [InlineData(2, 4, 7, 7, 6, true)]
    [InlineData(3, 1, 7, 3, 3, false)]
    public void IsReachableAtTime(int sx, int sy, int tx, int ty, int t, bool expected)
    {
        var actual = IsReachableAtTimeClass.IsReachableAtTime(sx, sy, tx, ty, t);
        Assert.Equal(expected, actual);
    }
}
