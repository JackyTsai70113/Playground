namespace playground.UnitTest;

public class _3218_MinimumCostTest
{
    [Theory]
    [InlineData(3, 2, new int[] { 1, 3 }, new int[] { 5 }, 13)]
    [InlineData(2, 2, new int[] { 7 }, new int[] { 4 }, 15)]
    [InlineData(3, 3, new int[] { 5, 3 }, new int[] { 5, 2 }, 27)]
    [InlineData(3, 3, new int[] { 5, 7 }, new int[] { 5, 6 }, 44)]
    public void MinimumCost(int m, int n, int[] A, int[] B, long expected)
    {
        var actual = _3218_MinimumCost.MinimumCost(m, n, A, B);
        Assert.Equal(expected, actual);
    }
}
