using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0857_MincostToHireWorkersTest
{
    [Theory]
    [InlineData(new int[] { 10, 20, 5 }, new int[] { 70, 50, 30 }, 2, 105.00000)]
    [InlineData(new int[] { 3, 1, 10, 10, 1 }, new int[] { 4, 8, 2, 2, 7 }, 3, 30.666666666666664)]
    [InlineData(new int[] { 3, 1, 10, 10, 1 }, new int[] { 4, 8, 2, 2, 7 }, 5, 200.00000)]
    public void MincostToHireWorkers(int[] quality, int[] wage, int k, double expected)
    {
        var actual = _0857_MincostToHireWorkers.MincostToHireWorkers(quality, wage, k);
        Assert.Equal(expected, actual);
    }
}
