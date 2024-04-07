namespace playground.UnitTest;

public class MinimumCostTest3108
{
    [Theory]
    [InlineData(5, "[[0,1,7],[1,3,7],[1,2,1]]", "[[0,3],[3,4]]", "[1,-1]")]
    [InlineData(3, "[[0,2,7],[0,1,15],[1,2,6],[1,2,1]]", "[[1,2]]", "[0]")]
    [InlineData(9, "[[0,4,7],[3,5,1],[1,3,5],[1,5,1]]", "[[0,4],[1,5],[3,0],[3,3],[3,2],[2,0],[7,7],[7,0]]", "[7,1,-1,0,-1,-1,0,-1]")]
    public void MinimumCost(int n, string edges, string query, string expected)
    {
        var actual = MinimumCost3108.MinimumCost(n, edges.To2dArr(), query.To2dArr());
        Assert.Equal(expected.ToArr(), actual);
        actual = MinimumCost3108.MinimumCost2(n, edges.To2dArr(), query.To2dArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
