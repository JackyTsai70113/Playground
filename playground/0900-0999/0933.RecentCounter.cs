namespace playground;

/// <summary>
/// https://leetcode.com/problems/number-of-recent-calls
/// </summary>
public class RecentCounter0933
{
    readonly Queue<int> q = new();
    public RecentCounter0933() { }

    public int Ping(int t)
    {
        q.Enqueue(t);
        while (q.Count > 1 && q.Peek() < t - 3000)
            q.Dequeue();
        return q.Count;
    }
}
