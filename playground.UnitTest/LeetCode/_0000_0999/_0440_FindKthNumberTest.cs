using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0440_FindKthNumberTest
{
    [Theory]
    [InlineData(13, 2, 10)]
    [InlineData(1, 1, 1)]
    [InlineData(681692778, 351251360, 416126219)]
    public void FindKthNumber(int n, int k, int expected)
    {
        var actual = _0440_FindKthNumber.FindKthNumber(n, k);
        Assert.Equal(expected, actual);
    }
}
