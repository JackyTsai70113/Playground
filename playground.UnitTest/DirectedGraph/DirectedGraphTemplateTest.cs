using playground.DirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedGraph;

public class DirectedGraphTemplateTest
{
    [Theory]
    [InlineData("[[1, 2], [2, 7], [7, 1], [7, 3], [3, 6], [6, 7]]", new int[] { 1, 2, 7, 3, 6, 6, 3, 7, 2, 1 })]
    public void DirectedGraphTemplate(string array, int[] expected)
    {
        int[][] edges = array.To2dArr<int>();

        var actual = DirectedGraphTemplateClass.DirectedGraphTemplate(edges);
        
        Assert.Equal(actual, expected);
    }
}
