using playground.UnionFinds;

namespace playground.Mathematics;

public class MinCostConnectPointsClass
{
    /// <summary>
    /// https://leetcode.com/problems/min-cost-to-connect-all-points<br/>
    /// Minimum spanning tree (MST)<br/>
    /// Prim's algroithm<br/>
    /// Kruskal's Algorithm: 按照「weight由小到大」的順序挑選edge，並且避免產生cycle
    /// </summary>
    /// <param name="ps"></
    public static int MinCostConnectPoints(int[][] ps)
    {
        int n = ps.Length;
        var pq = new PriorityQueue<(int from, int to, int dist), int>();

        for (int i = 0; i < n; ++i)
        {
            for (int j = i + 1; j < ps.Length; ++j)
            {
                int dist = Math.Abs(ps[i][0] - ps[j][0]) + Math.Abs(ps[i][1] - ps[j][1]);
                pq.Enqueue((i, j, dist), dist);
            }
        }

        var uf = new UnionFind(n);
        var res = 0;
        while (pq.Count > 0)
        {
            var (from, to, dist) = pq.Dequeue();
            if (!uf.AreConnected(from, to))
            {
                res += dist;
                uf.Connect(from, to);
            }
        }

        return res;
    }

    /// <summary>
    /// cur = 0
    /// 初始化 dists
    /// 從 cur 開始更新 `weight[v] = weight(cur, v)`，並記錄 `min = 最小 weight 的節點`
    /// 接著更新 cur 成 min
    /// 將 cost 加上 dists[min]
    /// </summary>
    public static int MinCostConnectPoints2(int[][] ps)
    {
        int n = ps.Length;
        var dist = new int[n];
        Array.Fill(dist, int.MaxValue - 1);
        // find minimum weight from cur to other, and update cur
        int minCost = 0;
        for (int connected = 1, ui = 0; connected < n; connected++)
        {
            dist[ui] = int.MaxValue;
            int min = ui;
            for (int vi = 1; vi < n; vi++)
            {
                if (dist[vi] != int.MaxValue)
                {
                    dist[vi] = Math.Min(
                        dist[vi],
                        Math.Abs(ps[ui][0] - ps[vi][0]) + Math.Abs(ps[ui][1] - ps[vi][1]));
                    if (dist[min] > dist[vi])
                        min = vi;
                }
            }
            minCost += dist[min];
            ui = min;
        }

        return minCost;
    }
}