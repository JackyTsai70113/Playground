using playground.DirectedGraph;

namespace playground.UnitTest.DirectedGraph;

public class DirectedGraphTemplateTest
{
    [Theory]
    [InlineData("[[1, 2], [2, 7], [7, 1], [7, 3], [3, 6], [6, 7]]", new int[] { 1, 2, 7, 3, 6, 6, 3, 7, 2, 1 })]
    public void DirectedGraphTemplate(string edges, int[] expected)
    {
        var actual = DirectedGraphTemplateClass.DirectedGraphTemplate(edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
