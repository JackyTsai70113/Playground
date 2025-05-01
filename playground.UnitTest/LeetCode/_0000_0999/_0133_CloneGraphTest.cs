using playground.LeetCode._0000_0999;
using static playground.LeetCode._0000_0999._0133_CloneGraph;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0133_CloneGraphTest
{
    [Theory]
    [InlineData("[[2,4],[1,3],[2,4],[1,3]]", "[[2,4],[1,3],[2,4],[1,3]]")]
    [InlineData("[[]]", "[[]]")]
    [InlineData("[]", "[]")]
    public void CloneGraph(string root, string expected)
    {
        var actual = _0133_CloneGraph.CloneGraph(ToNode(root));
        if (actual == null)
            Assert.Empty(expected.ToArr());
        else
            Assert.Equal(expected, actual.ToString());
    }

    private static Node ToNode(string str)
    {
        var arr = str.To2dArr();

        if (arr.Length == 0) return null;
        var nodeVals = str.To2dArr();
        var nodes = new Node[nodeVals.Length];
        for (int i = 0; i < nodeVals.Length; i++)
        {
            nodes[i] = new Node(i + 1);
        }
        for (int i = 0; i < nodeVals.Length; i++)
        {
            nodes[i].neighbors = nodeVals[i].Select(val => nodes[val - 1]).ToList();
        }
        return nodes[0];
    }
}
