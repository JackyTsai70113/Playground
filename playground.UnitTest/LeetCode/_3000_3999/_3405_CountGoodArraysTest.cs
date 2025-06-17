using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3405_CountGoodArraysTest
{
    [Theory]
    [InlineData(3, 2, 1, 4)]
    [InlineData(4, 2, 2, 6)]
    [InlineData(5, 2, 0, 2)]
    public void CountGoodArrays(int n, int m, int k, int expected)
    {
        var actual = _3405_CountGoodArrays.CountGoodArrays(n, m, k);
        Assert.Equal(expected, actual);
    }
}
