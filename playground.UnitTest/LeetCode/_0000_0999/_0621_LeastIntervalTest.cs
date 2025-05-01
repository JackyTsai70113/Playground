using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0621_LeastIntervalTest
{
    [Theory]
    [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 1, 6)]
    [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2, 8)]
    [InlineData(new char[] { 'A', 'C', 'B', 'B', 'D', 'B' }, 1, 6)]
    [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 3, 10)]
    public void LeastInterval(char[] tasks, int n, int expected)
    {
        var actual = _0621_LeastInterval.LeastInterval(tasks, n);
        Assert.Equal(expected, actual);
    }
}
