namespace playground;

public class _3275_ResultsArray
{
    public static int[] ResultsArray(int[][] queries, int k)
    {
        var res = new int[queries.Length];
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < queries.Length; i++)
        {
            var val = Math.Abs(queries[i][0]) + Math.Abs(queries[i][1]);
            while (pq.Count >= k && pq.Peek() > val)
                pq.Dequeue();
            if (pq.Count < k)
                pq.Enqueue(val, -val);
            if (pq.Count == k)
            {
                res[i] = pq.Peek();
            }
            else
            {
                res[i] = -1;
            }
        }
        return res;
    }
}
