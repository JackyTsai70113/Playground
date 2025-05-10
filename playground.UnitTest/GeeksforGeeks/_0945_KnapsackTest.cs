using playground.GeeksforGeeks;

namespace playground.UnitTest.GeeksforGeeks;

public class _0945_KnapsackTest
{
    [Theory]
    [InlineData(50, new[] { 60, 100, 120 }, new[] { 10, 20, 30 }, 220)]
    [InlineData(10, new[] { 60, 100, 120 }, new[] { 10, 20, 30 }, 60)]
    [InlineData(0, new[] { 60, 100, 120 }, new[] { 10, 20, 30 }, 0)]
    public void KnapsackTest(int W, int[] val, int[] wt, int expected)
    {
        var result = _0945_Knapsack.Knapsack(W, val, wt);
        Assert.Equal(expected, result);
        var result2 = _0945_Knapsack.Knapsack_OptimizeSpace(W, val, wt);
        Assert.Equal(expected, result2);
    }
}
