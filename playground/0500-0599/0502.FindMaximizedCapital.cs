namespace playground;

public class FindMaximizedCapital0502
{
    /// <summary>
    /// https://leetcode.com/problems/ipo
    /// </summary>
    public static int FindMaximizedCapital(int k, int w, int[] ps, int[] cs)
    {
        var arr = ps
            .Select((p, i) => (profit: p, capital: cs[i]))
            .OrderBy(x => x.capital)
            .ThenBy(x => x.profit)
            .ToArray();
        var pq = new PriorityQueue<int, int>();
        int n = ps.Length, res = w, i = 0;
        while (k-- > 0)
        {
            while (i < n && arr[i].capital <= res)
            {
                pq.Enqueue(arr[i].profit, -arr[i].profit);
                i++;
            }
            if (pq.Count == 0) break;
            res += pq.Dequeue();
        }
        return res;
    }
}
