namespace playground.UnitTest;

public class WaysToReachStairTest3154
{
    [Theory]
    [InlineData(0, 2)]
    [InlineData(1, 4)]
    [InlineData(16777205, 4457400)]
    public static void WaysToReachStair(int k, int expected)
    {
        var actual = WaysToReachStair3154.WaysToReachStair(k);
        Assert.Equal(expected, actual);
    }
}
