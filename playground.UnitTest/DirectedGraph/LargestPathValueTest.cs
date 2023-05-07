using playground.DirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedGraph;

public class LargestPathValueTest
{
    [Theory]
    [InlineData("abaca", new int[] { 0, 1, 0, 2, 2, 3, 3, 4 }, 3)]
    public void LargestPathValue(string colors, int[] array, int expected)
    {
        var edges = array.To2dArray(2);

        var actual = LargestPathValueClass.LargestPathValue(colors, edges);

        Assert.Equal(expected, actual);
    }
}
