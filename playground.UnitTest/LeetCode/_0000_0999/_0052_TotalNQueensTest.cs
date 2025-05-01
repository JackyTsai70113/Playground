using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0052_TotalNQueensTest
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(1, 1)]
    public void TotalNQueens(int n, int expected)
    {
        var actual = _0052_TotalNQueens.TotalNQueens(n);
        Assert.Equal(expected, actual);
    }
}
