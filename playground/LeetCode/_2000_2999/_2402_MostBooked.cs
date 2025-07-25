namespace playground.LeetCode._2000_2999;

public class _2402_MostBooked
{
    public static int MostBooked(int n, int[][] meetings)
    {
        Array.Sort(meetings, (x, y) => x[0] - y[0]);

        var available = new PriorityQueue<int, int>();
        for (int i = 0; i < n; i++) available.Enqueue(i, i);

        var booked = new PriorityQueue<(int room, int end), (int room, int end)>(
            Comparer<(int room, int end)>.Create((x, y) =>
                x.end != y.end ? x.end - y.end : x.room - y.room
            ));

        var count = new int[n];

        foreach (var m in meetings)
        {
            int curStart = m[0];
            int curEnd = m[1];
            while (booked.Count > 0 && booked.Peek().end <= curStart)
            {
                int room = booked.Dequeue().room;
                available.Enqueue(room, room);
            }
            if (available.Count > 0)
            {
                int room = available.Dequeue();
                count[room]++;
                booked.Enqueue((room, curEnd), (room, curEnd));
            }
            else
            {
                var (room, end) = booked.Dequeue();
                count[room]++;
                int newEnd = end + curEnd - curStart;
                booked.Enqueue((room, newEnd), (room, newEnd));
            }
        }
        return Array.IndexOf(count, count.Max());
    }
}
