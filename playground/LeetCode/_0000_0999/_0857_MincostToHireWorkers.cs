using Microsoft.VisualBasic;

namespace playground.LeetCode._0000_0999;

public class _0857_MincostToHireWorkers
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-to-hire-k-workers
    /// </summary>
    public static double MincostToHireWorkers(int[] quality, int[] wage, int k)
    {
        int n = quality.Length;
        (int q, double ratio)[] arr = quality
            .Select((q, i) => (q, ratio: (double)wage[i] / q))
            .OrderBy(x => x.ratio)
            .ToArray();
        PriorityQueue<(int q, double ratio), int> pq = new();
        double res = double.MaxValue;
        int sumQ = 0; ;
        foreach (var a in arr)
        {
            pq.Enqueue(a, -a.q);
            sumQ += a.q;
            if (pq.Count > k)
            {
                var (q, r) = pq.Dequeue();
                sumQ -= q;
            }
            if (pq.Count == k)
            {
                res = Math.Min(res, a.ratio * sumQ);
            }
        }
        return res;
    }
}

/*
10 20 5
70 50 30
7 5/2 6

20  5  10
50  30 70
5/2 6  7
    25*6
       15*7
       */