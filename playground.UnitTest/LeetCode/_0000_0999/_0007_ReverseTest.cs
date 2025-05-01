using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0007_ReverseTest
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    [InlineData(1534236469, 0)]
    public void CountPrimes(int n, int expected)
    {
        var actual = _0007_Reverse.Reverse(n);
        Assert.Equal(expected, actual);
    }
}
