using playground.DirectedWeightedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedWeightedGraph;

public class DirectedWeightedGraphTemplateTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 2, 7, 1, 7, 1, 1, 7, 3, 2, 3, 6, 2, 6, 7, 2 }, new int[] {})]
    public void DirectedWeightedGraphTemplate(int[] edgesArr, int[] expected)
    {
        var edges = edgesArr.To2dArray(3);

        var actual = DirectedWeightedGraphTemplateClass.DirectedWeightedGraphTemplate(edges);

        Assert.Equal(expected, actual);

    }
}
