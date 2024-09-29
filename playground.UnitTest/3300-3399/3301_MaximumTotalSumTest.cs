using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

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
