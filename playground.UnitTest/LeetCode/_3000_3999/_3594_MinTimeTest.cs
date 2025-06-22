using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3594_MinTimeTest
{
    [Theory]
    [InlineData(1, 1, 2, new[] { 5 }, new[] { 1.0, 1.3 }, 5)]
    [InlineData(3, 2, 3, new[] { 2, 5, 8 }, new[] { 1.0, 1.5, 0.75 }, 14.5)]
    [InlineData(2, 1, 2, new[] { 10, 10 }, new[] { 2.0, 2.0 }, -1)]
    [InlineData(11, 3, 5, new[] { 49, 60, 65, 68, 35, 18, 4, 83, 99, 82, 58 }, new[] { 1.85, 1.86, 1.29, 0.68, 0.56 }, 269.91)]
    [InlineData(12, 3, 4, new[] { 88, 86, 9, 19, 17, 77, 19, 54, 93, 35, 4, 79 }, new[] { 1.23, 1.4, 1.07, 0.97 }, 285.1)]
    public void MinTime(int n, int m, int k, int[] time, double[] mul, double expected)
    {
        var actual = new _3594_MinTime().MinTime(n, m, k, time, mul);
        Assert.Equal(expected, actual, 5);
    }
}
