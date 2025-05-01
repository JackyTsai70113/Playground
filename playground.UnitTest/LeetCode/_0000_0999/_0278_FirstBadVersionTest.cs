using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0278_FirstBadVersionTest
{
    [Theory]
    [InlineData(5, 4, 4)]
    [InlineData(1, 1, 1)]
    public void FirstBadVersion(int n, int bad, int expected)
    {
        var actual = new _0278_FirstBadVersion().FirstBadVersion(n, bad);
        Assert.Equal(expected, actual);
    }
}
