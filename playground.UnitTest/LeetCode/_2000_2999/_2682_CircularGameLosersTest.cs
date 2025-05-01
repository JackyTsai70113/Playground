using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2682_CircularGameLosersTest
{
    [Theory]
    [InlineData(5, 2, "[4,5]")]
    [InlineData(4, 4, "[2, 3, 4]")]
    public void CircularGameLosers(int n, int k, string expected)
    {
        var actual = _2682_CircularGameLosers.CircularGameLosers(n, k);
        Assert.Equal(expected.ToArr(), actual);
    }
}
