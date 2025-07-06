namespace playground.LeetCode._3000_3999;

public class _3607_ProcessQueries
{
    public static int[] ProcessQueries(int c, int[][] connections, int[][] queries)
    {
        var ds = new DisjointSet(c);

        bool[] isOnline = new bool[c + 1];
        Array.Fill(isOnline, true);

        foreach (var con in connections)
        {
            ds.Union(con[0], con[1]);
        }

        List<int> results = new();

        foreach (var q in queries)
        {
            int type = q[0];
            int stationId = q[1];

            if (type == 1)
            {
                if (isOnline[stationId])
                {
                    results.Add(stationId);
                }
                else
                {
                    int root = ds.Find(stationId);
                    if (ds.stations[root].Any())
                    {
                        results.Add(ds.stations[root].Min);
                    }
                    else
                    {
                        results.Add(-1);
                    }
                }
            }
            else
            {
                isOnline[stationId] = false;
                int root = ds.Find(stationId);
                ds.stations[root].Remove(stationId);
            }
        }

        return results.ToArray();
    }

    public class DisjointSet
    {
        public readonly int[] groups;
        public readonly SortedSet<int>[] stations;
        public DisjointSet(int n)
        {
            groups = new int[n + 1];
            stations = new SortedSet<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                groups[i] = i;
                stations[i] = new SortedSet<int> { i };
            }
        }

        public int Find(int u)
        {
            if (groups[u] == u) return u;
            return groups[u] = Find(groups[u]);
        }

        public bool Union(int u1, int u2)
        {
            int g1 = Find(u1), g2 = Find(u2);
            if (g1 == g2) return false;
            if (stations[g1].Count < stations[g2].Count) (g1, g2) = (g2, g1);
            groups[g2] = g1;
            foreach (var station in stations[g2])
            {
                stations[g1].Add(station);
            }
            stations[g2].Clear();
            return true;
        }
    }
}
