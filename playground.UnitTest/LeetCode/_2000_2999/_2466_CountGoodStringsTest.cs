using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2466_CountGoodStringsTest
{
    [Theory]
    [InlineData(3, 3, 1, 1, 8)]
    [InlineData(2, 3, 1, 2, 5)]
    public void CountGoodStrings(int low, int high, int zero, int one, int expected)
    {
        var actual = _2466_CountGoodStrings.CountGoodStrings(low, high, zero, one);
        Assert.Equal(expected, actual);
    }
}
