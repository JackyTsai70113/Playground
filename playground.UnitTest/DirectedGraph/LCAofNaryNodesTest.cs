using playground.DirectedGraph;

namespace playground.UnitTest.DirectedGraph;

public class LCAofNaryNodesTest
{
    private readonly NaryTreeNode TestDataRoot;
    public LCAofNaryNodesTest()
    {
        var node1 = new NaryTreeNode(1);
        var node2 = new NaryTreeNode(2);
        var node3 = new NaryTreeNode(3);
        var node4 = new NaryTreeNode(4);
        node2.children.Add(node3);
        node2.children.Add(node4);
        var node5 = new NaryTreeNode(5);
        var node6 = new NaryTreeNode(6);
        node5.children.Add(node6);
        node1.children.Add(node2);
        node1.children.Add(node5);

        TestDataRoot = node1;
    }
    [Theory]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 6 }, new int[] { 5 })]
    [InlineData(new int[] { 5 }, new int[] { 5 })]
    [InlineData(new int[] { 5, 6 }, new int[] { 5 })]
    [InlineData(new int[] { 4 }, new int[] { 4 })]
    [InlineData(new int[] { 4, 6 }, new int[] { 4, 5 })]
    [InlineData(new int[] { 4, 5 }, new int[] { 4, 5 })]
    [InlineData(new int[] { 4, 5, 6 }, new int[] { 4, 5 })]
    [InlineData(new int[] { 3 }, new int[] { 3 })]
    [InlineData(new int[] { 3, 6 }, new int[] { 3, 5 })]
    [InlineData(new int[] { 3, 5 }, new int[] { 3, 5 })]
    [InlineData(new int[] { 3, 5, 6 }, new int[] { 3, 5 })]
    [InlineData(new int[] { 3, 4 }, new int[] { 2 })]
    [InlineData(new int[] { 3, 4, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 3, 4, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 3, 4, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 2 }, new int[] { 2 })]
    [InlineData(new int[] { 2, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 4 }, new int[] { 2 })]
    [InlineData(new int[] { 2, 4, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 4, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 4, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 3 }, new int[] { 2 })]
    [InlineData(new int[] { 2, 3, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 3, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 3, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 3, 4 }, new int[] { 2 })]
    [InlineData(new int[] { 2, 3, 4, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 3, 4, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 3, 4, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 4 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 4, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 4, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 4, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3, 4 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3, 4, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3, 4, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 3, 4, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 4 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 4, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 4, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 4, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 5, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 4, 6 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1 })]
    public void LCAofNaryNodes(int[] nodes, int[] expected)
    {
        var actual = LCAofNaryNodesClass.LCAofNaryNodes(TestDataRoot, nodes.ToList());
        Assert.Equal(expected.ToList(), actual);
    }
}