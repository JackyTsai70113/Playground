namespace playground.GeeksforGeeks;

public class MostBookedClass
{
    /// <summary>
    /// https://www.geeksforgeeks.org/problems/meeting-rooms-iii/1
    /// </summary>
    /// <param name="n"></param>
    /// <param name="meetings"></param>
    /// <returns></returns>
    public static int MostBooked(int n, int[][] meetings)
    {
        Array.Sort(meetings, (x, y) => x[0] - y[0]);

        PriorityQueue<int, int> available =
            new(Comparer<int>.Create((x, y) => x - y));
        foreach (var i in Enumerable.Range(0, n))
        {
            available.Enqueue(i, i);
        }

        PriorityQueue<(int room, int end), (int room, int end)> booked =
            new(Comparer<(int room, int end)>.Create((x, y) =>
                x.end == y.end ?
                x.room - y.room :
                x.end - y.end
            ));

        var counts = new int[n];
        foreach (var (start, end) in meetings.Select(m => (start: m[0], end: m[1])))
        {
            while (booked.Count > 0 && booked.Peek().end <= start)
            {
                var (room, _) = booked.Dequeue();
                available.Enqueue(room, room);
            }
            if (available.Count > 0)
            {
                var room = available.Dequeue();
                booked.Enqueue((room, end), (room, end));
                counts[room]++;
            }
            else
            {
                var (room, endTime) = booked.Dequeue();
                int newEnd = endTime + end - start;
                booked.Enqueue((room, newEnd), (room, newEnd));
                counts[room]++;
            }
        }
        return Array.IndexOf(counts, counts.Max());
    }
}