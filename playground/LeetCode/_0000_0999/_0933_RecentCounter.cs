namespace playground.LeetCode._0000_0999;

/// <summary>
/// https://leetcode.com/problems/number-of-recent-calls
/// </summary>
public class _0933_RecentCounter
{
    readonly Queue<int> q = new();
    public _0933_RecentCounter() { }

    public int Ping(int t)
    {
        q.Enqueue(t);
        while (q.Count > 1 && q.Peek() < t - 3000)
            q.Dequeue();
        return q.Count;
    }
}
