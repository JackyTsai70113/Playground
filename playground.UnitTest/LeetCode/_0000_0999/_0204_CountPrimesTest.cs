using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0204_CountPrimesTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    [InlineData(2, 0)]
    [InlineData(10, 4)]
    [InlineData(11, 4)]
    [InlineData(5000000, 348513)]
    public void CountPrimes(int n, int expected)
    {
        var actual = _0204_CountPrimes.CountPrimes(n);
        Assert.Equal(expected, actual);
    }
}
