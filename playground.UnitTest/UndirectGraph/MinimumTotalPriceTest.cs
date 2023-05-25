using playground.UndirectedGraph;

namespace playground.UnitTest.UndirectGraph;

public class MinimumTotalPriceTest
{
    [Theory]
    [InlineData(1, "[]", "[2]", "[[0, 0]]", 1)]
    [InlineData(2, "[0, 1]", "[2, 2]", "[[0, 0]]", 1)]
    [InlineData(4, "[[1, 0], [1, 2], [1, 3]]", "[2, 2, 10, 6]", "[[0, 3], [2, 1], [2, 3]]", 23)]
    [InlineData(9, "[[2,5],[3,4],[4,1],[1,7],[6,7],[7,0],[0,5],[5,8]]", "[4,4,6,4,2,4,2,14,8]", "[[1,5],[2,7],[4,3],[1,8],[2,8],[4,3],[1,5],[1,4],[2,1],[6,0],[0,7],[8,6],[4,0],[7,5],[7,5],[6,0],[5,1],[1,1],[7,5],[1,7],[8,7],[2,3],[4,1],[3,5],[2,5],[3,7],[0,1],[5,8],[5,3],[5,2]]", 429)]
    public void MinimumTotalPrice(int n, string edgesStr, string priceStr, string tripsStr, int expected)
    {
        var edges = edgesStr.To2dArr<int>();
        var price = priceStr.ToArr();
        var trips = tripsStr.To2dArr<int>();
        var actual = MinimumTotalPriceClass.MinimumTotalPrice(n, edges, price, trips);
        Assert.Equal(expected, actual);
    }
}
