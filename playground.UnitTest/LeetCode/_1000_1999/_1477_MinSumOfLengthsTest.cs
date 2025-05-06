using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1477_MinSumOfLengthsTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 4, 3 }, 3, 2)]
    [InlineData(new int[] { 7, 3, 4, 7 }, 7, 2)]
    [InlineData(new int[] { 4, 3, 2, 6, 2, 3, 4 }, 6, -1)]
    [InlineData(new int[] { 3, 1, 1, 1, 5, 1, 2, 1 }, 3, 3)]
    [InlineData(new int[] { 1, 1, 1, 2, 2, 2, 4, 4 }, 6, 6)]
    public void MinSumOfLengths(int[] A, int target, int expected)
    {
        var actual = _1477_MinSumOfLengths.MinSumOfLengths(A, target);
        Assert.Equal(expected, actual);
    }
}
