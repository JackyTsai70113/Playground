namespace playground.LeetCode._3000_3999;

public class _3362_MaxRemoval
{
    public static int MaxRemoval(int[] A, int[][] queries)
    {
        queries = queries.OrderBy(q => q[0]).ThenByDescending(q => q[1]).ToArray();

        int len = A.Length, qLen = queries.Length;
        PriorityQueue<int, int> pq = new();

        int[] end = new int[len + 1];
        int cur = 0, idx = 0;

        for (int i = 0; i < len; i++) // Iterate each item
        {
            cur += end[i]; // update query freq with ended here
            while (idx < qLen && queries[idx][0] <= i) // Enqueue the queries which started before cur index
            {
                pq.Enqueue(-queries[idx][1], -queries[idx++][1]);
            }

            while (cur < A[i])
            {
                if (pq.Count == 0 || (-pq.Peek()) < i)
                    return -1;

                end[-pq.Dequeue() + 1]--;
                cur++;
            }
        }


        return pq.Count;
    }
}
