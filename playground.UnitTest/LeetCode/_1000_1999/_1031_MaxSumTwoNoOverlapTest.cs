using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1031_MaxSumTwoNoOverlapTest
{
    [Theory]
    [InlineData(new int[] { 0, 6, 5, 2, 2, 5, 1, 9, 4 }, 1, 2, 20)]
    [InlineData(new int[] { 3, 8, 1, 3, 2, 1, 8, 9, 0 }, 3, 2, 29)]
    [InlineData(new int[] { 2, 1, 5, 6, 0, 9, 5, 0, 3, 8 }, 4, 3, 31)]
    public void MinSumOfLengths(int[] A, int firstLen, int secondLen, int expected)
    {
        var actual = _1031_MaxSumTwoNoOverlap.MaxSumTwoNoOverlap(A, firstLen, secondLen);
        Assert.Equal(expected, actual);
    }
}
