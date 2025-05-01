namespace playground._1900_1999;

public class _1942_SmallestChair_cs
{
    public static int SmallestChair(int[][] times, int targetFriend)
    {
        int currentChair = 0, targetChair = -1;
        PriorityQueue<int, int> available = new();
        PriorityQueue<(int chair, int leaving), int> occupied = new();
        int targetArrival = times[targetFriend][0];
        Array.Sort(times, (x, y) => x[0] - y[0]);
        foreach (var time in times)
        {
            int arrival = time[0], leaving = time[1];
            // 考慮現在時間，清出可用位置
            while (occupied.Count > 0 && occupied.Peek().leaving <= arrival)
            {
                int availableChair = occupied.Dequeue().chair;
                available.Enqueue(availableChair, availableChair);
            }
            // 計算下一個可用位置
            int nextChair = available.Count == 0 ? currentChair++ : available.Dequeue();
            if (arrival == targetArrival)
            {
                targetChair = nextChair;
                break;
            }
            // 將下一個可用位置標記為已占用
            occupied.Enqueue((nextChair, leaving), leaving);
        }
        return targetChair;
    }
}
