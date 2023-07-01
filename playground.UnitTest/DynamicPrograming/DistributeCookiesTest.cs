using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class DistributeCookiesTest
{
    [Theory]
    [InlineData(new int[] { 8, 15, 8 }, 2, 16)]
    [InlineData(new int[] { 8, 15, 10, 20, 8 }, 2, 31)]
    [InlineData(new int[] { 6, 1, 3, 2, 2, 4, 1, 2 }, 3, 7)]
    public void DistributeCookies(int[] cookies, int k, int expected)
    {
        var actual = DistributeCookiesClass.DistributeCookies(cookies, k);

        Assert.Equal(expected, actual);
    }
}
