# weighted graph(賦權圖)

## Dijkstra's algorithm

An algorithm for finding the shortest paths between nodes in a weighted graph.

Algorithm:

```csharp
/// <summary>
/// 取得 source 到各節點的最短路徑長
/// </summary>
/// <param name="source">開始的節點</param>
/// <param name="g">weighted graph</param>
/// <returns>從 <c>source</c> 到各節點的最短路徑長</returns>
private static int[] Dijkstra(int source, List<(int, int)>[] g)
{
    int n = g.Length;
    var res = new int[n];
    Array.Fill(res, int.MaxValue);
    res[source] = 0;
    var pq = new PriorityQueue<(int u, int d), int>();
    pq.Enqueue((source, 0), 0);
    while (pq.Count > 0)
    {
        var (u, total) = pq.Dequeue();
        if (res[u] != total)
            continue;
        foreach (var (v, d) in g[u])
        {
            if (total + d < res[v])
            {
                res[v] = total + d;
                pq.Enqueue((v, res[v]), res[v]);
            }
        }
    }
    return res;
}
```
