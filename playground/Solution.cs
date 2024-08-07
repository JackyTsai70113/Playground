namespace playground;

public class Solution
{
    // public static int[] TimeTaken3241(int[][] edges)
    // {
    //     int n = edges.Length + 1;
    //     var g = new List<int>[n];
    //     for (int i = 0; i < n; i++) g[i] = new();
    //     foreach (var e in edges)
    //     {
    //         g[e[0]].Add(e[1]);
    //         g[e[1]].Add(e[0]);
    //     }
    //     var dist = new int[n, n];
    //     for (int i = 0; i < n; i++)
    //     {
    //         for (int j = 0; j < n; j++)
    //             dist[i, j] = int.MaxValue;
    //         foreach (var v in g[i])
    //             dist[i, v] = v % 2 == 0 ? 2 : 1;
    //         dist[i, i] = 0;
    //     }
    //     for (int k = 0; k < n; k++)
    //     {
    //         for (int i = 0; i < n; i++)
    //         {
    //             for (int j = 0; j < n; j++)
    //             {
    //                 if (i == j || i == k || k == j) continue;
    //                 dist[i, j] = (int)Math.Min(dist[i, j], (long)dist[i, k] + dist[k, j]);
    //             }
    //         }
    //     }
    //     int[] res = new int[n], time = new int[n];
    //     for (int i = 0; i < n; i++)
    //     {
    //         for (int j = 0; j < n; j++)
    //         {
    //             res[i] = Math.Max(res[i], dist[i, j]);
    //         }
    //     }

    //     return res;
    // }
}