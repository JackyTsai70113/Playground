using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2894_DifferenceOfSumsTest
{
    [Theory]
    [InlineData(10, 3, 19)]
    [InlineData(5, 6, 15)]
    [InlineData(5, 1, -15)]
    public void DifferenceOfSums(int n, int m, int expected)
    {
        var actual = _2894_DifferenceOfSums.DifferenceOfSums(n, m);
        Assert.Equal(expected, actual);
    }
}
