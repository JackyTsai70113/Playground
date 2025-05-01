using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0576_FindPathsTest
{
    [Theory]
    [InlineData(2, 2, 2, 0, 0, 6)]
    [InlineData(1, 3, 3, 0, 1, 12)]
    public void FindPaths(int m, int n, int maxMove, int r, int c, int expected)
    {
        var actual = _0576_FindPaths.FindPaths(m, n, maxMove, r, c);
        Assert.Equal(expected, actual);
    }
}
