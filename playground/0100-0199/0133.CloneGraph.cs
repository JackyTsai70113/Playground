namespace playground;

public class CloneGraph0133
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public override string ToString()
        {
            var strs = new string[101];
            var count = 0;
            var q = new Queue<Node>();
            q.Enqueue(this);
            var seen = new HashSet<int> { val };
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                var nodeVals = new List<int>();
                count = Math.Max(count, node.val);
                foreach (var nei in node.neighbors)
                {
                    nodeVals.Add(nei.val);
                    if (!seen.Contains(nei.val))
                    {
                        q.Enqueue(nei);
                        seen.Add(nei.val);
                    }
                }
                strs[node.val - 1] = '[' + string.Join(',', nodeVals) + ']';
            }
            var res = '[' + string.Join(',', strs.Take(count)) + ']';
            return res;
        }
    }

    /// <summary>
    /// https://leetcode.com/problems/clone-graph
    /// </summary>
    public static Node CloneGraph(Node node)
    {
        if (node == null) return null;
        Node res = new(node.val);
        var d = new Dictionary<int, Node> { [node.val] = res };
        var q = new Queue<(Node, Node)>();
        q.Enqueue((res, node));
        while (q.Count > 0)
        {
            var (clone, ori) = q.Dequeue();
            foreach (var nei in ori.neighbors)
            {
                if (!d.ContainsKey(nei.val))
                {
                    d[nei.val] = new Node(nei.val);
                    q.Enqueue((d[nei.val], nei));
                }
                clone.neighbors.Add(d[nei.val]);
            }
        }
        return res;
    }
}