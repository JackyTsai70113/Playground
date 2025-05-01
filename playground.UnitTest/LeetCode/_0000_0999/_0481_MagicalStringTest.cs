using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0481_MagicalStringTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(6, 3)]
    [InlineData(8, 4)]
    [InlineData(100000, 49972)]
    public void MagicalString(int n, int expected)
    {
        var actual = _0481_MagicalString.MagicalString(n);
        Assert.Equal(expected, actual);
    }
}
