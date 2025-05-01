using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2517_MaximumTastinessTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 3, 4 }, 3, 1)]
    [InlineData(new int[] { 2, 2, 2, 3, 3, 4 }, 3, 1)]
    [InlineData(new int[] { 10, 1, 3, 7, 5, 9, 5 }, 3, 4)]
    [InlineData(new int[] { 4, 2, 1 }, 2, 3)]
    [InlineData(new int[] { 4, 2, 2, 1 }, 2, 3)]
    [InlineData(new int[] { 13, 5, 1, 8, 21, 2 }, 3, 8)]
    [InlineData(new int[] { 1, 3, 1 }, 2, 2)]
    [InlineData(new int[] { 7, 7, 7, 7 }, 2, 0)]
    public void MaximumTastiness(int[] price, int k, int expected)
    {
        var actual = _2517_MaximumTastiness.MaximumTastiness(price, k);
        Assert.Equal(expected, actual);
    }
}
