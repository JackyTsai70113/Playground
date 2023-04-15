using playground.UndirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.UndirectGraph;

public class MinimumTotalPriceTest
{
    [Theory]
    [InlineData(1, new int[] { }, new int[] { 2 }, new int[] { 0, 0 }, 1)]
    // [InlineData(2, new int[] { 0, 1 }, new int[] { 2, 2 }, new int[] { 0, 0 }, 1)]
    // [InlineData(4, new int[] { 1, 0, 1, 2, 1, 3 }, new int[] { 2, 2, 10, 6 }, new int[] { 0, 3, 2, 1, 2, 3 }, 23)]
    // [InlineData(9, new int[] { 2, 5, 3, 4, 4, 1, 1, 7, 6, 7, 7, 0, 0, 5, 5, 8 }, new int[] { 4, 4, 6, 4, 2, 4, 2, 14, 8 }, new int[] { 1, 5, 2, 7, 4, 3, 1, 8, 2, 8, 4, 3, 1, 5, 1, 4, 2, 1, 6, 0, 0, 7, 8, 6, 4, 0, 7, 5, 7, 5, 6, 0, 5, 1, 1, 1, 7, 5, 1, 7, 8, 7, 2, 3, 4, 1, 3, 5, 2, 5, 3, 7, 0, 1, 5, 8, 5, 3, 5, 2 }, 429)]
    public void MinimumTotalPrice(int n, int[] edgesArr, int[] price, int[] tripsArr, int expect)
    {
        int[][] edges = edgesArr.To2dArray(2);
        int[][] trips = tripsArr.To2dArray(2);
        var actual = MinimumTotalPriceClass.MinimumTotalPrice(n, edges, price, trips);
        Assert.Equal(expect, actual);
    }
}
