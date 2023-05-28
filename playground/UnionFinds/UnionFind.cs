namespace playground.UnionFinds;

public class UnionFind
{
    private readonly int n;
    public int[] Groups { get; private set; }
    public int[] Ranks { get; private set; }
    public UnionFind(int n)
    {
        this.n = n;
        Groups = new int[n];
        Ranks = new int[n];
        for (int i = 0; i < n; ++i)
        {
            Groups[i] = i;
            Ranks[i] = 1;
        }
    }

    public UnionFind(UnionFind uf)
    {
        Groups = uf.Groups.ToArray();
        Ranks = uf.Ranks.ToArray();
    }
    public int GroupCount()
    {
        var hs = new HashSet<int>();
        for (int node = 0; node < n; ++node)
        {
            hs.Add(Find(node));
        }
        return hs.Count;
    }
    public int Find(int node)
    {
        if (Groups[node] != node)
        {
            Groups[node] = Find(Groups[node]);
        }
        return Groups[node];
    }
    public void Join(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        if (group1 == group2) return;
        if (Ranks[group2] > Ranks[group1])
        {
            Groups[group1] = group2;
            Ranks[group2] += Ranks[group1];
        }
        else
        {
            Groups[group2] = group1;
            Ranks[group1] += Ranks[group2];
        }
    }
    public bool AreConnected(int node1, int node2)
    {
        int group1 = Find(node1);
        int group2 = Find(node2);
        return group1 == group2;
    }
}