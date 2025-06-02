using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1191_KConcatenationMaxSumTest
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, 3, 9)]
    [InlineData(new int[] { 1, -2, 1 }, 5, 2)]
    [InlineData(new int[] { -1, -2 }, 7, 0)]
    [InlineData(new int[] { -3, 1, 4, -4, 6 }, 1, 7)]
    [InlineData(new int[] { -3, 1, 4, -4, 6 }, 2, 11)]
    [InlineData(new int[] { -3, 1, 4, -4, 6 }, 3, 15)]
    [InlineData(new int[] { -3, 1, 4, -4, 6 }, 6, 27)]
    public void MinScoreTriangulation(int[] A, int k, int expected)
    {
        int actual = _1191_KConcatenationMaxSum.KConcatenationMaxSum(A, k);
        Assert.Equal(expected, actual);
    }
}
