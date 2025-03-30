namespace playground;

public class MinCostConnectPoints1584
{
    /// <summary>
    /// https://leetcode.com/problems/min-cost-to-connect-all-points
    /// </summary> 
    /// <remarks>
    /// Minimum spanning tree (MST)<br/>
    /// Prim's algroithm<br/>
    /// Kruskal's Algorithm: 按照「weight由小到大」的順序挑選edge，並且避免產生cycle
    /// </remarks>
    public static int MinCostConnectPoints(int[][] ps)
    {
        var n = ps.Length;
        var pq = new PriorityQueue<(int, int, int), int>();
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                var dist = Math.Abs(ps[i][0] - ps[j][0]) + Math.Abs(ps[i][1] - ps[j][1]);
                pq.Enqueue((i, j, dist), dist);
            }
        }
        int count = 1, res = 0;
        var ds = new DisjointSet(n);
        while (count < n)
        {
            var (i, j, dist) = pq.Dequeue();
            if (ds.Find(i) != ds.Find(j))
            {
                ds.Join(i, j);
                count++;
                res += dist;
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
