using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3578_CountPartitionsTest
{
    [Theory]
    [InlineData(new int[] { 9, 4, 1, 3, 7 }, 4, 6)]
    [InlineData(new int[] { 3, 3, 4 }, 0, 2)]
    public void CountPartitions(int[] A, int k, int expected)
    {
        var actual = _3578_CountPartitions.CountPartitions(A, k);
        Assert.Equal(expected, actual);
    }
}
