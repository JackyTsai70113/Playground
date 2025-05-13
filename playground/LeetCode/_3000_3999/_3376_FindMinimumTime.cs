namespace playground.LeetCode._3000_3999;

public class _3376_FindMinimumTime
{
    public static int FindMinimumTime(IList<int> strength, int k)
    {
        int n = strength.Count, res = -1;
        var pq = new PriorityQueue<(int t, int x, int mask), int>();
        pq.Enqueue((0, 1, (int)Math.Pow(2, n) - 1), 0);
        while (pq.Count > 0 & res == -1)
        {
            for (int i = pq.Count; i > 0; i--)
            {
                var (t, x, mask) = pq.Dequeue();
                if (mask == 0)
                {
                    res = t;
                    break;
                }
                for (int j = 0; j < strength.Count; j++)
                {
                    if ((mask & 1 << j) > 0)
                    {
                        var tt = t + (strength[j] + x - 1) / x;
                        pq.Enqueue((tt, x + k, mask ^ 1 << j), tt);
                    }
                }
            }
        }
        return res;
    }
}
