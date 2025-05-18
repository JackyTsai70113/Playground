namespace playground.LeetCode._2000_2999;

public class _2402_MostBooked
{
    public static int MostBooked(int n, int[][] meetings)
    {
        Array.Sort(meetings, (x, y) => x[0] - y[0]);

        PriorityQueue<int, int> available =
            new(Enumerable.Range(0, n).Select(x => (x, x)),
                Comparer<int>.Create((x, y) => x - y));

        PriorityQueue<(int room, int end), (int room, int end)> booked =
            new(Comparer<(int room, int end)>.Create((x, y) =>
                x.end == y.end ?
                x.room - y.room :
                x.end - y.end
            ));

        var counts = new int[n];
        foreach (var m in meetings)
        {
            int curStart = m[0];
            int curEnd = m[1];
            while (booked.Count > 0 && booked.Peek().end <= curStart)
            {
                var (room, _) = booked.Dequeue();
                available.Enqueue(room, room);
            }
            if (available.Count > 0)
            {
                var room = available.Dequeue();
                counts[room]++;
                booked.Enqueue((room, curEnd), (room, curEnd));
            }
            else
            {
                var (room, end) = booked.Dequeue();
                counts[room]++;
                int newEnd = end + curEnd - curStart;
                booked.Enqueue((room, newEnd), (room, newEnd));
            }
        }
        return Array.IndexOf(counts, counts.Max());
    }
}
