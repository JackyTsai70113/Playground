namespace playground.UndirectedGraph;

public class MinimumTotalPriceClass
{
    public static int MinimumTotalPrice(int n, int[][] edges, int[] price, int[][] trips)
    {
        var graph = Enumerable.Range(0, n).Select(_ => new List<int>()).ToArray();
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }

        int[] passCount = new int[n];
        foreach (var t in trips)
        {
            var q = new Queue<(int, List<int>)>();
            q.Enqueue((t[0], new List<int> { t[0] }));
            var seen = new int[n];
            seen[t[0]] = 1;
            while (q.Count > 0)
            {
                (int node, List<int> passedNodes) = q.Dequeue();
                if (node == t[1])
                {
                    foreach (var passNode in passedNodes)
                    {
                        passCount[passNode]++;
                    }
                    break;
                }
                foreach (var nei in graph[node])
                {
                    if (seen[nei] == 1) continue;
                    seen[nei] = 1;
                    var newPassNodes = new List<int>(passedNodes) { nei };
                    q.Enqueue((nei, newPassNodes));
                }
            }
        }

        var costs = passCount.Select((x, i) => new int[] { x * price[i] / 2, x * price[i] }).ToArray();

        void dfs(int i, int fa)
        {
            foreach (var nei in graph[i])
            {
                if (nei == fa) continue;
                dfs(nei, i);
                costs[i][0] += costs[nei][1];
                costs[i][1] += Math.Min(costs[nei][0], costs[nei][1]);
            }
        }
        dfs(0, -1);
        return costs[0].Min();
    }
}
