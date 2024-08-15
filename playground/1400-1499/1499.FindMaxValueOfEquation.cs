namespace playground;

public class FindMaxValueOfEquation1499
{
    public static int FindMaxValueOfEquation(int[][] points, int k)
    {
        var pq = new PriorityQueue<(int x, int y), int>();
        int max = int.MinValue;
        foreach (var p in points)
        {
            while (pq.Count > 0 && p[0] - pq.Peek().x > k)
                pq.Dequeue();
            if (pq.Count > 0)
            {
                int x = pq.Peek().x, y = pq.Peek().y;
                max = Math.Max(max, y + p[1] + p[0] - x);
            }
            pq.Enqueue((p[0], p[1]), -p[1] + p[0]);
        }
        return max;
    }
}
