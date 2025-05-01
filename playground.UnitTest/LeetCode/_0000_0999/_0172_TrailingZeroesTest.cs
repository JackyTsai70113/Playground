using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0172_TrailingZeroesTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(3, 0)]
    [InlineData(5, 1)]
    [InlineData(30, 7)]
    [InlineData(10000, 2499)]
    public void TrailingZeroes(int n, int expected)
    {
        var actual = _0172_TrailingZeroes.TrailingZeroes(n);
        Assert.Equal(expected, actual);
    }
}
