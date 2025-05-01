using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0371_GetSumTest
{
    [Theory]
    [InlineData(-1, 1, 0)]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    public void GetSum(int a, int b, int expected)
    {
        var actual = _0371_GetSum.GetSum(a, b);
        Assert.Equal(expected, actual);
    }
}
