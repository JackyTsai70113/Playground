using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0935_KnightDialerTest
{
    [Theory]
    [InlineData(1, 10)]
    [InlineData(2, 20)]
    [InlineData(3131, 136006598)]
    public void KnightDialer(int n, int expected)
    {
        var actual = _0935_KnightDialer.KnightDialer(n);
        Assert.Equal(expected, actual);
        var actual2 = _0935_KnightDialer.KnightDialer2(n);
        Assert.Equal(expected, actual2);
    }
}
