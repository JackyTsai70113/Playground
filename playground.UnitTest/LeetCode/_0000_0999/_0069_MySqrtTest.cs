using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0069_MySqrtTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(124314239, 11149)]
    public void MySqrt(int x, int expected)
    {
        var actual = _0069_MySqrt.MySqrt(x);
        Assert.Equal(expected, actual);
    }
}
