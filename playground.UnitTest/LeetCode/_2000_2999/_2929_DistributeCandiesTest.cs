using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2929_DistributeCandiesTest
{
    [Theory]
    [InlineData(5, 2, 3)]
    [InlineData(3, 3, 10)]
    public void DistributeCandies(int n, int limit, long expected)
    {
        var actual = _2929_DistributeCandies.DistributeCandies(n, limit);
        Assert.Equal(expected, actual);
    }
}
