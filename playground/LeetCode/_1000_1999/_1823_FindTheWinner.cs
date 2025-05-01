namespace playground;

public class _1823_FindTheWinner
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-winner-of-the-circular-game
    /// </summary>
    public static int FindTheWinner(int n, int k)
    {
        var l = Enumerable.Range(1, n).ToList();
        int cur = 0;
        while (l.Count > 1)
        {
            cur = (cur + k % l.Count + l.Count - 1) % l.Count;
            l.RemoveAt(cur);
            cur %= l.Count;
        }
        return l[0];
    }
}
