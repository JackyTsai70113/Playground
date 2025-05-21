using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2305_DistributeCookiesTest
{
    [Theory]
    [InlineData(new int[] { 8, 15, 8 }, 2, 16)]
    [InlineData(new int[] { 8, 15, 10, 20, 8 }, 2, 31)]
    [InlineData(new int[] { 6, 1, 3, 2, 2, 4, 1, 2 }, 3, 7)]
    public void DistributeCookies(int[] cookies, int k, int expected)
    {
        int actual;
        actual = _2305_DistributeCookies.DistributeCookies(cookies, k);
        Assert.Equal(expected, actual);

        actual = _2305_DistributeCookies.DistributionCookies_Optimize(cookies, k);
        Assert.Equal(expected, actual);
    }
}
