namespace playground.PriorityQueue;

public class TotalCostClass
{
    public static long TotalCost(int[] costs, int k, int ca)
    {
        long res = 0;
        var lpq = new PriorityQueue<int, int>();
        var rpq = new PriorityQueue<int, int>();
        int n = costs.Length, l = 0, r = n - 1;
        for (; l < ca; ++l)
            lpq.Enqueue(costs[l], costs[l]);
        for (; l <= r && n - 1 - r < ca; --r)
            rpq.Enqueue(costs[r], costs[r]);
        for (int j = 0; j < k; ++j)
        {
            int x;
            if (lpq.Count > 0)
            {
                x = lpq.Peek();
            }
            else
            {
                x = int.MaxValue;
            }
            var y = rpq.Count > 0 ? rpq.Peek() : int.MaxValue;
            if (x <= y)
            {
                res += x;
                lpq.Dequeue();
                if (l <= r)
                {
                    lpq.Enqueue(costs[l], costs[l]);
                    l++;
                }
            }
            else
            {
                res += y;
                rpq.Dequeue();
                if (l <= r)
                {
                    rpq.Enqueue(costs[r], costs[r]);
                    r--;
                }
            }
        }
        return res;
    }
}
