using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0629_KInversePairsTest
{
    [Theory]
    [InlineData(3, 0, 1)]
    [InlineData(3, 1, 2)]
    [InlineData(4, 4, 5)]
    [InlineData(4, 6, 1)]
    [InlineData(4, 7, 0)]
    [InlineData(1000, 1000, 663677020)]
    public void KInversePairs(int n, int k, int expected)
    {
        var actual = _0629_KInversePairs.KInversePairs(n, k);
        Assert.Equal(expected, actual);
    }
}
