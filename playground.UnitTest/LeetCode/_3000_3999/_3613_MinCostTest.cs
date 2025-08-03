using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3613_MinCostTest
{
    [Theory]
    [InlineData(5, "[[0,1,4],[1,2,3],[1,3,2],[3,4,6]]", 2, 4)]
    [InlineData(4, "[[0,1,5],[1,2,5],[2,3,5]]", 1, 5)]
    [InlineData(4, "[[0,1,5],[1,2,5],[2,3,5]]", 4, 0)]
    public void MinCost(int n, string edges, int k, int expected)
    {
        var actual = _3613_MinCost.MinCost(n, edges.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
