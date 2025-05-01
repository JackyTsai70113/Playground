using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0072_MinDistanceTest
{
    [Theory]
    [InlineData("horse", "ros", 3)]
    [InlineData("intention", "execution", 5)]
    public void MinDistance(string A, string B, int expected)
    {
        var actual = _0072_MinDistance.MinDistance(A, B);
        Assert.Equal(expected, actual);
    }
}
