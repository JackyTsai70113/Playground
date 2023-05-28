using playground.UndirectedGraph;
namespace playground.UnitTest.UndirectGraph;

public class CollectTheCoinsTest
{
    [Theory]
    [InlineData(new int[] { 1, 0, 0, 0, 0, 1 }, "[[0, 1],[1, 2],[2, 3],[3, 4],[4, 5]]", 2)]
    [InlineData(new int[] { 0, 0, 0, 1, 1, 0, 0, 1 }, "[[0, 1],[0, 2],[1, 3],[1, 4],[2, 5],[5, 6],[5, 7]]", 2)]
    public void CollectTheCoins(int[] coins, string edges, int expected)
    {
        var actual = CollectTheCoinsClass.CollectTheCoins(coins, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
