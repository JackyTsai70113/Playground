
namespace playground.UndirectedGraph;

public class CollectTheCoinsClass
{
    /// <remarks>https://leetcode.com/problems/collect-coins-in-a-tree</remarks>>
    public static int CollectTheCoins(int[] coins, int[][] edges)
    {
        int n = coins.Length;
        var graph = Enumerable.Range(0, n).Select(x => new HashSet<int>()).ToArray();
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }

        var degrees = new int[n];
        var q = new Queue<int>();
        for (int i = 0; i < n; ++i)
        {
            degrees[i] = graph[i].Count;
            if (degrees[i] == 1)
            {
                q.Enqueue(i);
            }
        }

        var cnt = new int[n];
        for (int i = 0; i < n; ++i)
        {
            if (coins[i] != 1)
            {
                cnt[i] = -1;
            }
        }
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            if (cnt[u] == 2 || graph[u].Count == 0)
            {
                continue;
            }

            var v = graph[u].First();
            if (cnt[u] == 0)
            {
                cnt[v] = Math.Max(cnt[v], 1);
            }
            else if (cnt[u] == 1)
            {
                cnt[v] = Math.Max(cnt[v], 2);
            }
            degrees[u]--;
            degrees[v]--;
            if (degrees[v] == 1)
            {
                q.Enqueue(v);
            }
            graph[u].Remove(v);
            graph[v].Remove(u);
        }
        var res = 0;
        int dfs(int fa, int u)
        {
            var res = 0;
            foreach (var v in graph[u])
            {
                if (v != fa)
                {
                    res += 1 + dfs(u, v);
                }
            }
            return res;
        }
        for (int i = 0; i < n; ++i)
        {
            if (degrees[i] > 0)
            {
                res = 2 * dfs(-1, i);
                break;
            }
        }

        return res;
    }
}
