using playground.DirectedGraph;

namespace playground.UnitTest.DirectedGraph;

public class LargestPathValueTest
{
    [Theory]
    [InlineData("abaca", "[[0, 1], [0, 2], [2, 3], [3, 4]]", 3)]
    [InlineData("a", "[[0, 0]]", -1)]
    [InlineData("rrrde", "[[4,2],[3,4],[0,3],[1,0],[2,1]]", -1)]
    [InlineData("aaa", "[[1,2],[2,1]]", -1)]
    public void LargestPathValue(string colors, string edges, int expected)
    {
        var actual = LargestPathValueClass.LargestPathValue(colors, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
