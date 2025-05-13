using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3301_MaximumTotalSumTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 4, 3 }, 10)]
    [InlineData(new int[] { 15, 10 }, 25)]
    [InlineData(new int[] { 2, 2, 1 }, -1)]
    public void MinStartingIndex(int[] A, int expected)
    {
        var actual = _3301_MaximumTotalSum.MaximumTotalSum(A);
        Assert.Equal(expected, actual);
    }
}
