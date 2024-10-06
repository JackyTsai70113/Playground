namespace playground_3300_3399;

public class _3311_ConstructGridLayout
{
    public static int[][] ConstructGridLayout(int n, int[][] edges)
    {
        var g = new List<int>[n];
        var count = new int[n];
        for (int i = 0; i < n; i++)
        {
            g[i] = new();
        }
        foreach (var e in edges)
        {
            count[e[0]]++;
            count[e[1]]++;
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }

        var first = Array.IndexOf(count, count.Min());
        var visited = new bool[n];
        Array.Fill(visited, false);
        visited[first] = true;
        int cur = first;
        var row = new List<int> { cur };
        while (cur == first || count[cur] != count[first])
        {
            int next = -1;
            foreach (var v in g[cur])
            {
                if (!visited[v] && (next == -1 || count[v] < count[next]))
                {
                    next = v;
                }
            }
            visited[next] = true;
            row.Add(next);
            cur = next;
        }
        var res = new int[n / row.Count][];
        res[0] = row.ToArray();
        for (int i = 1; i < res.Length; i++)
        {
            res[i] = new int[row.Count];
        }
        for (int i = 0; i < res.Length - 1; i++)
        {
            for (int j = 0; j < res[0].Length; j++)
            {
                cur = res[i][j];
                int next = -1;
                foreach (var v in g[cur])
                {
                    if (!visited[v])
                    {
                        next = v;
                    }
                }
                visited[next] = true;
                res[i + 1][j] = next;
            }
        }
        return res;
    }
}
