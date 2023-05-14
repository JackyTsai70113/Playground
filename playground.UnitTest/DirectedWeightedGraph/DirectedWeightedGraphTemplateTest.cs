using playground.DirectedWeightedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedWeightedGraph;

public class DirectedWeightedGraphTemplateTest
{
    [Theory]
    [InlineData("[[1, 2, 1], [1, 2, 1], [7, 1, 1], [7, 1, 1], [1, 7, 1], [3, 2, 1], [3, 6, 1], [2, 6, 1], [7, 2, 1]]", "[]")]
    public void DirectedWeightedGraphTemplate(string arr, string expectedStr)
    {
        var edges = arr.To2dArr<int>();

        var actual = DirectedWeightedGraphTemplateClass.DirectedWeightedGraphTemplate(edges);

        Assert.Equal(expectedStr.ToArr<int>(), actual);
    }
}
