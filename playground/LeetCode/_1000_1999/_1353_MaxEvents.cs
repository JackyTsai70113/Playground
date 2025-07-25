namespace playground.LeetCode._1000_1999;

public class _1353_MaxEvents
{
    public static int MaxEvents(int[][] events)
    {
        Array.Sort(events, (a, b) => a[0] != b[0] ? a[0] - b[0] : a[1] - b[1]);
        var pq = new PriorityQueue<int, int>();
        int idx = 0, day = 0, count = 0;
        while (idx < events.Length || pq.Count > 0)
        {
            if (pq.Count == 0)
            {
                day = events[idx][0];
            }
            while (idx < events.Length && events[idx][0] <= day)
            {
                pq.Enqueue(events[idx][1], events[idx][1]);
                idx++;
            }
            while (pq.Count > 0 && pq.Peek() < day)
            {
                pq.Dequeue();
            }
            if (pq.Count > 0)
            {
                count++;
                pq.Dequeue();
            }
            day++;
        }
        return count;
    }
}
