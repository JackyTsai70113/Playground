namespace playground;

public class SumOfDistancesInTree0834
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-distances-in-tree
    /// </summary>
    /// <remarks>bfs version</remarks>
    public static int[] SumOfDistancesInTree(int n, int[][] edges)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        void Bfs(int node, int[] res)
        {
            var q = new Queue<(int u, int par)>();
            q.Enqueue((node, -1));
            int pathsSum = 0, pathLen = 0;
            while (q.Count > 0)
            {
                pathsSum += q.Count * pathLen;
                for (int i = q.Count - 1; i >= 0; i--)
                {
                    var (u, par) = q.Dequeue();
                    foreach (var v in g[u])
                    {
                        if (v == par) continue;
                        q.Enqueue((v, u));
                    }
                }
                pathLen++;
            }
            res[node] = pathsSum;
        }

        void CalCounts(int u, int parent, int[] counts)
        {
            foreach (var v in g[u])
            {
                if (v == parent) continue;
                CalCounts(v, u, counts);
                counts[u] += counts[v];
            }
            counts[u]++;
        }

        void Bfs2(int node, int[] counts, int[] res)
        {
            var q = new Queue<(int u, int par)>();
            q.Enqueue((node, -1));
            while (q.Count > 0)
            {
                for (int i = q.Count - 1; i >= 0; i--)
                {
                    var (u, par) = q.Dequeue();
                    foreach (var v in g[u])
                    {
                        if (v == par) continue;
                        q.Enqueue((v, u));
                        res[v] = res[u] - counts[v] + (n - counts[v]);
                    }
                }
            }
        }

        var counts = new int[n];
        CalCounts(0, -1, counts);
        var res = new int[n];
        Bfs(0, res);
        Bfs2(0, counts, res);
        return res;
    }

    /// <remarks>dfs version</remarks>
    public static int[] SumOfDistancesInTree2(int n, int[][] edges)
    {
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }
        void Dfs(int u, int par, int[] counts, int[] res)
        {
            foreach (var v in g[u])
            {
                if (v == par) continue;
                // 先算完 child 的節點數量，再算 parent 的
                Dfs(v, u, counts, res);
                counts[u] += counts[v];
                res[u] += res[v] + counts[v];
            }
            counts[u]++;
        }

        void Dfs2(int u, int par, int[] counts, int[] res)
        {
            foreach (var v in g[u])
            {
                if (v == par) continue;
                // 先算完 parent 的距離，再算 child 的
                res[v] = res[u] - counts[v] + n - counts[v];
                Dfs2(v, u, counts, res);
            }
        }

        var counts = new int[n];
        var res = new int[n];
        Dfs(0, -1, counts, res);
        Dfs2(0, -1, counts, res);
        return res;
    }
}
