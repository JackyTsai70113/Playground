using playground.DirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedGraph;

public class LargestPathValueTest
{
    [Theory]
    [InlineData("abaca", "[[0, 1], [0, 2], [2, 3], [3, 4]]", 3)]
    [InlineData("a", "[[0, 0]]", -1)]
    public void LargestPathValue(string colors, string str, int expected)
    {
        var edges = str.To2dArr<int>();

        var actual = LargestPathValueClass.LargestPathValue(colors, edges);

        Assert.Equal(expected, actual);
    }
}
