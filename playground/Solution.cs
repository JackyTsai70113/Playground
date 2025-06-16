using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace playground;

public class Solution
{
    // public static long MinOperations(int[][] qs)
    // {
    //     int n = qs.Length;
    //     long res = 0;
    //     for (int i = 0; i < n; i++)
    //     {
    //         int a = qs[i][0], b = qs[i][1];
    //         int[] count1 = GetCounts(a - 1), count2 = GetCounts(b);
    //         int[] count = new int[9];
    //         for (int j = 0; j < 9; j++)
    //         {
    //             count[j] = count2[j] - count1[j];
    //             Console.Write(count[j] + " ");
    //         }
    //         Console.WriteLine();
    //         // [0, 2, 3] => [0, 4, 1]2 => [0, 4, 0]4
    //         while (count.Select((x, i) => (x, i)).Any(y => y.x > 0 && y.i > 0))
    //         {
    //             int c = 0, d = 0;
    //             for (int j = 8; j >= 1; j--)
    //             {
    //                 if (count[j] > 0)
    //                 {
    //                     if (d == 0)
    //                     {
    //                         d = j;
    //                     }
    //                     else if (c == 0)
    //                     {
    //                         c = j;
    //                         break;
    //                     }
    //                 }
    //             }
    //             if (count[d] > 1)
    //             {
    //                 count[d - 1] += count[d] / 2 * 2;
    //                 count[d] %= 2;
    //                 res += count[d] / 2 * 2;
    //             }
    //             else
    //             {
    //                 count[d] = 0;
    //                 count[d - 1] += 1;
    //                 count[c] -= 1;
    //                 if (c > 0)
    //                     count[c - 1] += 1;
    //                 res += 1;
    //             }
    //         }
    //     }
    //     return res;
    // }

    // public static int[] GetCounts(int r)
    // {
    //     var res = new int[9];
    //     if (r == 0) return res;
    //     for (int i = 1, cur = 4, presum = 0; i < 9; i++)
    //     {
    //         res[i] = Math.Min(r, cur - 1) - presum;
    //         presum += res[i];
    //         cur *= 4;
    //     }
    //     return res;
    // }

    // public int[] AssignEdgeWeights(int[][] edges, int[][] queries)
    // {
    //     int n = edges.Length + 1;
    //     var g = new List<int>[n + 1];
    //     for (int i = 0; i <= n; i++) g[i] = new();
    //     foreach (var e in edges)
    //     {
    //         g[e[0]].Add(e[1]);
    //         g[e[1]].Add(e[0]);
    //     }

    //     var dist = new int[n + 1, n + 1];
    //     for (int i = 0; i <= n; i++)
    //     {
    //         for (int j = 0; j <= n; j++)
    //         {
    //             dist[i, j] = -1;
    //         }
    //     }

    //     var q = new Queue<int>();
    //     int edgesCount(int start, int end)
    //     {
    //         if (dist[start, end] != -1) return dist[start, end];
    //         dist[start, start] = 0;
    //         q.Clear();
    //         q.Enqueue(start);
    //         while (q.Count > 0)
    //         {
    //             var u = q.Dequeue();
    //             foreach (var v in g[u])
    //             {
    //                 if (dist[start, v] == -1)
    //                 {
    //                     dist[start, v] = dist[start, u] + 1;
    //                     q.Enqueue(v);
    //                 }
    //             }
    //         }
    //         return dist[start, end];
    //     }

    //     long MOD = (long)1e9 + 7;
    //     var precompute = new long[100001];
    //     precompute[1] = 1;
    //     for (int i = 1; i < 100001; i++)
    //     {
    //         precompute[i] = precompute[i] * 2 % MOD;
    //     }
    //     var res = new List<int>();
    //     foreach (var qu in queries)
    //     {
    //         var count = edgesCount(qu[0], qu[1]);
    //         res.Add((int)precompute[count]);
    //     }
    //     return res.ToArray();
    // }

    // public int MaxProfit(int n, int[] A, int[] B, int[][] hierarchy, int budget)
    // {
    //     var g = new List<int>[n + 1];
    //     for (int i = 0; i < n; i++) g[i] = new();
    //     var indegree = new int[n + 1];
    //     foreach (var e in hierarchy)
    //     {
    //         g[e[0]].Add(e[1]);
    //         indegree[e[1]]++;
    //     }

    //     int maxProfit = 0;
    //     var buyProfit = new int[budget + 1];
    //     Array.Fill(buyProfit, int.MinValue);
    //     var notBuyProfit = new int[budget + 1];
    //     Array.Fill(notBuyProfit, int.MinValue);
    //     if (A[0] <= budget) buyProfit[A[0]] = B[0] - A[0];

    //     void Bt(int u)
    //     {
    //         maxProfit = Math.Max(maxProfit, buyProfit.Max());
    //         maxProfit = Math.Max(maxProfit, notBuyProfit.Max());

    //         var lastBuyProfit = buyProfit.ToArray();
    //         var lastNotBuyProfit = notBuyProfit.ToArray();

    //         foreach (var v in g[u])
    //         {
    //             // not buy
    //             for (int i = 0; i <= budget; i++)
    //             {
    //                 notBuyProfit[i] = Math.Max(lastBuyProfit[i], lastNotBuyProfit[i]);
    //             }

    //             // buy
    //             buyProfit = new int[budget + 1];
    //             Array.Fill(buyProfit, int.MinValue);
    //             for (int i = budget; i >= A[v] / 2; i--)
    //             {
    //                 if (lastBuyProfit[i - A[v] / 2] != int.MinValue)
    //                 {
    //                     buyProfit[i] = Math.Max(buyProfit[i], lastBuyProfit[i - A[v] / 2] + B[v] - A[v] / 2);
    //                 }
    //             }
    //             for (int i = budget; i >= A[v]; i--)
    //             {
    //                 if (lastNotBuyProfit[i - A[v]] != int.MinValue)
    //                 {
    //                     buyProfit[i] = Math.Max(buyProfit[i], lastNotBuyProfit[i - A[v]] + B[v] - A[v]);
    //                 }
    //             }
    //             Bt(v);

    //             buyProfit = lastBuyProfit;
    //             notBuyProfit = lastNotBuyProfit;
    //         }
    //     }

    //     Bt(1);
    //     return maxProfit;
    // }
}