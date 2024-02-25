namespace playground.UnionFinds;

public class CountCompleteComponentsClass
{
    public static int CountCompleteComponents(int n, int[][] edges)
    {
        if (n == 1)
            return 1;
        var uf = new UnionFind(n);
        var countEdge = new int[n];
        var groups = new HashSet<int>[n];

        foreach (var e in edges)
        {
            uf.Connect(e[0], e[1]);
        }
        foreach (var e in edges)
        {
            int g = uf.Find(e[0]);
            if (groups[g] == null) groups[g] = new();
            groups[g].Add(e[0]);
            groups[g].Add(e[1]);
            countEdge[g]++;
        }
        var res = 0;
        var seen = new bool[n];
        for (int i = 0; i < n; ++i)
        {
            int g = uf.Find(i);
            if (seen[g])
            {
                continue;
            }
            seen[g] = true;
            if (g == i && countEdge[i] == 0)
            {
                res++;
                continue;
            }
            int a = groups[g].Count;
            if (countEdge[g] == a * (a - 1) / 2)
            {
                res++;
            }

        }
        return res;
    }
}
