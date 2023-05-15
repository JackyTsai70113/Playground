using playground.DirectedWeightedGraph;

namespace playground.UnitTest.DirectedWeightedGraph;

public class ShortestPathCalculatorGraphTest
{
    [Theory]
    [InlineData(3, 2, 6)]
    public void ShortestPathCalculatorGraph(int node1, int node2, int expected)
    {
        var graph = new ShortestPathCalculatorGraphClass(4, new int[][]{
            new int[] {0, 2, 5}, new int[]{0, 1, 2}, new int[]{1, 2, 1}, new int[]{3, 0, 3}
            });
        Assert.Equal(graph.ShortestPath(node1, node2), expected);
    }

    [Theory]
    [InlineData(0, 3, -1)]
    public void ShortestPathCalculatorGraph2(int node1, int node2, int expected)
    {
        var graph = new ShortestPathCalculatorGraphClass(4, new int[][]{
            new int[] {0, 2, 5}, new int[]{3, 1, 2}
            });
        Assert.Equal(graph.ShortestPath(node1, node2), expected);
    }
}
