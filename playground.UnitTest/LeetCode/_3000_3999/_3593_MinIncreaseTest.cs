using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3593_MinIncreaseTest
{
    [Theory]
    [InlineData(3, "[[0,1],[0,2]]", new[] { 2, 1, 3 }, 1)]
    [InlineData(3, "[[0,1],[1,2]]", new[] { 5, 1, 4 }, 0)]
    [InlineData(5, "[[0,4],[0,1],[1,2],[1,3]]", new[] { 3, 4, 1, 1, 7 }, 1)]
    public void MinIncrease(int n, string edges, int[] cost, int expected)
    {
        var actual = new _3593_MinIncrease().MinIncrease(n, edges.To2dArr(), cost);
        Assert.Equal(expected, actual);
    }
}
