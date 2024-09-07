namespace playground;

public class TimeTaken3241
{
    List<int>[] g;
    (int first, int second)[] farthest;
    int[] res;
    public int[] TimeTaken(int[][] edges)
    {
        int n = edges.Length + 1;
        g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        farthest = new (int first, int second)[n];
        BuildFarthestDistance(0);
        res = new int[n];
        CalculateFarthestWithParent(0, 0);
        return res;
    }

    void BuildFarthestDistance(int u)
    {
        int first = 0, second = 0;
        foreach (var v in g[u])
        {
            if (v < u) continue;
            BuildFarthestDistance(v);
            int dist = ((v & 1) == 1 ? 1 : 2) + farthest[v].first;
            if (dist >= first)
                (first, second) = (dist, first);
            else if (dist > second)
                second = dist;
        }
        farthest[u] = (first, second);
    }

    void CalculateFarthestWithParent(int u, int parentDist)
    {
        res[u] = Math.Max(farthest[u].first, parentDist);
        foreach (var v in g[u])
        {
            if (v < u) continue;
            int toParent = (u & 1) == 1 ? 1 : 2;
            int toChild = (v & 1) == 1 ? 1 : 2;
            int distExceptThisChild =
                farthest[u].first == toChild + farthest[v].first ?
                farthest[u].second : farthest[u].first;
            CalculateFarthestWithParent(v, toParent + Math.Max(parentDist, distExceptThisChild));
        }
    }
}
