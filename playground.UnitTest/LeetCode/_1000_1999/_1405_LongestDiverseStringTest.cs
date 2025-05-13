using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1405_LongestDiverseStringTest
{
    [Theory]
    [InlineData(1, 1, 7, "ccaccbcc")]
    [InlineData(7, 1, 0, "aabaa")]
    [InlineData(0, 8, 11, "ccbccbccbbccbbccbbc")]
    public void LongestDiverseString(int a, int b, int c, string expected)
    {
        var actual = _1405_LongestDiverseString.LongestDiverseString(a, b, c);
        Assert.Equal(expected, actual);
    }
}
