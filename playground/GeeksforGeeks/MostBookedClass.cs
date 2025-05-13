namespace playground.GeeksforGeeks;

public class MostBooked
{
    public static int MostBookedClass(int n, int[][] meetings)
    {
        Array.Sort(meetings, (a, b) => a[0] - b[0]);
        var booked = new int[n];
        var endTimes = new PriorityQueue<int, int>();
        var maxBooked = 0;
        var maxCount = 0;

        foreach (var meeting in meetings)
        {
            while (endTimes.Count > 0 && endTimes.Peek() <= meeting[0])
            {
                endTimes.Dequeue();
            }

            if (endTimes.Count < n)
            {
                booked[endTimes.Count]++;
                endTimes.Enqueue(meeting[1], meeting[1]);
            }
            else
            {
                booked[0]++;
                endTimes.Dequeue();
                endTimes.Enqueue(meeting[1], meeting[1]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (booked[i] > maxCount)
            {
                maxCount = booked[i];
                maxBooked = i;
            }
        }

        return maxBooked;
    }
}
