using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3594_MinTimeTest
{
    [Theory]
    [InlineData(1, 1, 2, new[] { 5 }, new[] { 1.0, 1.3 }, 5)]
    [InlineData(3, 2, 3, new[] { 2, 5, 8 }, new[] { 1.0, 1.5, 0.75 }, 14.5)]
    [InlineData(2, 1, 2, new[] { 10, 10 }, new[] { 2.0, 2.0 }, -1)]
    public void MinTime(int n, int m, int k, int[] time, double[] mul, double expected)
    {
        var actual = new _3594_MinTime().MinTime(n, m, k, time, mul);
        Assert.Equal(expected, actual, 5);
    }
}
