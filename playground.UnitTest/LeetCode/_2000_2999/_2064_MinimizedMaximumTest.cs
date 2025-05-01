using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2064_MinimizedMaximumTest_cs
{
    [Theory]
    [InlineData(6, new int[] { 11, 6 }, 3)]
    [InlineData(7, new int[] { 15, 10, 10 }, 5)]
    [InlineData(1, new int[] { 100000 }, 100000)]
    [InlineData(1, new int[] { 1 }, 1)]
    public void MinimizedMaximum(int n, int[] qs, int expected)
    {
        var actual = _2064_MinimizedMaximum_cs.MinimizedMaximum(n, qs);
        Assert.Equal(actual, expected);
    }
}
