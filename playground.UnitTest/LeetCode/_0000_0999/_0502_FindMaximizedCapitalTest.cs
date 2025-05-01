using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0502_FindMaximizedCapitalTest
{
    [Theory]
    [InlineData(2, 0, new int[] { 1, 2, 3 }, new int[] { 0, 1, 1 }, 4)]
    [InlineData(3, 0, new int[] { 1, 2, 3 }, new int[] { 0, 1, 2 }, 6)]
    public void FindMaximizedCapital(int k, int w, int[] ps, int[] cs, int expected)
    {
        var actual = _0502_FindMaximizedCapital.FindMaximizedCapital(k, w, ps, cs);
        Assert.Equal(expected, actual);
    }
}
