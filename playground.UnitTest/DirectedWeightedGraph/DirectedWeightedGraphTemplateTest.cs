using playground.DirectedWeightedGraph;

namespace playground.UnitTest.DirectedWeightedGraph;

public class DirectedWeightedGraphTemplateTest
{
    [Theory]
    [InlineData("[[1, 2, 1], [1, 2, 1], [7, 1, 1], [7, 1, 1], [1, 7, 1], [3, 2, 1], [3, 6, 1], [2, 6, 1], [7, 2, 1]]", new int[] { })]
    public void DirectedWeightedGraphTemplate(string edges, int[] expected)
    {
        var actual = DirectedWeightedGraphTemplateClass.DirectedWeightedGraphTemplate(edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
