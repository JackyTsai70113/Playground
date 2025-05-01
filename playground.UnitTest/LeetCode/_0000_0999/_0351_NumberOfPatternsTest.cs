using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0351_NumberOfPatternsTest
{
    [Theory]
    [InlineData(1, 1, 9)]
    [InlineData(1, 2, 65)]
    [InlineData(2, 5, 9152)]
    public void NumberOfPatterns(int m, int n, int expected)
    {
        var actual = _0351_NumberOfPatterns.NumberOfPatterns(m, n);
        Assert.Equal(expected, actual);
    }
}
