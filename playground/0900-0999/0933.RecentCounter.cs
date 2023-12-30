namespace playground;

/// <summary>
/// https://leetcode.com/problems/number-of-recent-calls
/// </summary>
public class RecentCounter_0933
{
    Queue<int> q;
    public RecentCounter_0933()
    {
        q = new();
    }

    public int Ping(int t)
    {
        q.Enqueue(t);
        while (q.Count > 1 && q.Peek() < t - 3000)
            q.Dequeue();
        return q.Count;
    }
}
