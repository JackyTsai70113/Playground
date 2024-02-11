namespace playground.UnitTest;

public class MinSpeedOnTimeTest1870
{
    [Theory]
    [InlineData("[1,3,2]", 6, 1)]
    [InlineData("[1,3,2]", 2.7, 3)]
    [InlineData("[1,3,2]", 1.9, -1)]
    [InlineData("[1,1]", 1, -1)]
    public void MinSpeedOnTime(string dist, double hour, int expected)
    {
        var actual = MinSpeedOnTime1870.MinSpeedOnTime(dist.ToArr(), hour);
        Assert.Equal(expected, actual);
    }
}
