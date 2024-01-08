using static playground.CloneGraph0133;

namespace playground.UnitTest;

public class CloneGraphTest0133
{
    [Theory]
    [InlineData("[[2,4],[1,3],[2,4],[1,3]]", "[[2,4],[1,3],[2,4],[1,3]]")]
    [InlineData("[[]]", "[[]]")]
    [InlineData("[]", "[]")]
    public void CloneGraph(string root, string expected)
    {
        var actual = CloneGraph0133.CloneGraph(ToNode(root));
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
