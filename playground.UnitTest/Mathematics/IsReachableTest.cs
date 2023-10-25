using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class IsReachableTest
{
    [Theory]
    [InlineData(6, 9, false)]
    [InlineData(4, 8, true)]
    [InlineData(4, 7, true)]
    public void IsReachable(int x, int y, bool expected)
    {
        var actual = IsReachableClass.IsReachable(x, y);
        Assert.Equal(expected, actual);
    }
}
