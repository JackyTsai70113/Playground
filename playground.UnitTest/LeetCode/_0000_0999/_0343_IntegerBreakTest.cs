using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0343_IntegerBreakTest
{
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 4)]
    [InlineData(5, 6)]
    [InlineData(6, 9)]
    [InlineData(10, 36)]
    public void Test(int n, int expected)
    {
        int actual = _0343_IntegerBreak.IntegerBreak_DP(n);
        Assert.Equal(expected, actual);

        int actual2 = _0343_IntegerBreak.IntegerBreak_Math(n);
        Assert.Equal(expected, actual2);
    }
}
