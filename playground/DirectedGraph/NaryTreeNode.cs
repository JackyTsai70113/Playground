namespace playground.DirectedGraph;

public class NaryTreeNode
{
    public int val;
    public List<NaryTreeNode> children;

    public NaryTreeNode(int val)
    {
        this.val = val;
        this.children = new List<NaryTreeNode>();
    }
}
