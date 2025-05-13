namespace playground.UnitTest.LeetCode._1000_1999;

public class _1870_MinSpeedOnTimeTest
{
    [Theory]
    [InlineData("[1,3,2]", 6, 1)]
    [InlineData("[1,3,2]", 2.7, 3)]
    [InlineData("[1,3,2]", 1.9, -1)]
    [InlineData("[1,1]", 1, -1)]
    public void MinSpeedOnTime(string dist, double hour, int expected)
    {
        var actual = _1870_MinSpeedOnTime.MinSpeedOnTime(dist.ToArr(), hour);
        Assert.Equal(expected, actual);
    }
}
