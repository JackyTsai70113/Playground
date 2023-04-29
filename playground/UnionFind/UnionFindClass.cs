namespace playground.UnionFind;

public class UnionFindClass
{
    private readonly int[] groups;
    private readonly int[] ranks;
    public UnionFindClass(int n)
    {
        groups = new int[n];
        ranks = new int[n];
        for (int i = 0; i < n; ++i)
        {
            groups[i] = i;
        }
    }
    public int Find(int node)
    {
        if (groups[node] != node)
        {
            groups[node] = Find(groups[node]);
        }
        return groups[node];
    }
    public void Join(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        if (ranks[group1] > ranks[group2])
        {
            groups[group2] = group1;
        }
        else if (ranks[group1] < ranks[group2])
        {
            groups[group1] = group2;
        }
        else
        {
            groups[group2] = group1;
            ranks[group1]++;
        }
    }
    public bool AreConnected(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        return group1 == group2;
    }
}
