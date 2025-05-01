namespace playground.LeetCode._2000_2999;

public class _2462_TotalCost
{
    public static long TotalCost(int[] costs, int k, int candidates)
    {
        int n = costs.Length;
        var choosed = new bool[n];

        var pq1 = new PriorityQueue<int, int>();
        int lefti = 0;
        for (; lefti < Math.Min(n, candidates); lefti++)
        {
            choosed[lefti] = true;
            pq1.Enqueue(lefti, costs[lefti]);
        }

        var pq2 = new PriorityQueue<int, int>();
        var righti = 0;
        for (; righti < Math.Min(n, candidates); righti++)
        {
            if (choosed[n - 1 - righti])
                break;
            choosed[n - 1 - righti] = true;
            pq2.Enqueue(n - 1 - righti, costs[n - 1 - righti]);
        }

        long res = 0;
        while (k > 0)
        {
            int index = -1, cost = int.MaxValue;
            if (pq1.Count > 0)
            {
                index = pq1.Peek();
                cost = costs[index];
            }
            if (pq2.Count > 0 && costs[pq2.Peek()] < cost)
            {
                index = pq2.Dequeue();
                cost = costs[index];

                res += cost;
                if (!choosed[n - 1 - righti])
                {
                    choosed[n - 1 - righti] = true;
                    pq2.Enqueue(n - 1 - righti, costs[n - 1 - righti]);
                    righti++;
                }
            }
            else
            {
                pq1.Dequeue();
                res += cost;
                if (lefti < n && !choosed[lefti])
                {
                    choosed[lefti] = true;
                    pq1.Enqueue(lefti, costs[lefti]);
                    lefti++;
                }
            }
            k--;
        }
        return res;
    }
}
