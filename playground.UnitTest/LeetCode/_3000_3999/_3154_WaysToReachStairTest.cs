namespace playground.UnitTest.LeetCode._3000_3999;

public class _3154_WaysToReachStairTest
{
    [Theory]
    [InlineData(0, 2)]
    [InlineData(1, 4)]
    [InlineData(16777205, 4457400)]
    public static void WaysToReachStair(int k, int expected)
    {
        var actual = _3154_WaysToReachStair.WaysToReachStair(k);
        Assert.Equal(expected, actual);
    }
}
