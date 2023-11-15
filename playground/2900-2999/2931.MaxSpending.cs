namespace playground;

public class MaxSpending_2931
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-spending-after-buying-items
    /// </summary>
    public static long MaxSpending(int[][] vs)
    {
        int m = vs.Length, n = vs[0].Length;
        var pq = new PriorityQueue<(int, int, int), int>();
        for (int i = 0; i < m; ++i)
            pq.Enqueue((vs[i][^1], i, n - 1), vs[i][^1]);
        long res = 0;
        for (int day = 1; day <= m * n; day++)
        {
            var (v, i, j) = pq.Dequeue();
            res += (long)v * day;
            if (j > 0) pq.Enqueue((vs[i][j - 1], i, j - 1), vs[i][j - 1]);
        }
        return res;
    }
}
