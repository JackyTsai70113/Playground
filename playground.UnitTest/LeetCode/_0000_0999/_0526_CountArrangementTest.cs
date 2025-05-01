using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0526_CountArrangementTest
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(1, 1)]
    public void CountArrangement(int n, int expected)
    {
        var actual = _0526_CountArrangement.CountArrangement(n);
        Assert.Equal(expected, actual);
    }
}
