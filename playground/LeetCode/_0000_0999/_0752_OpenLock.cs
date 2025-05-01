namespace playground.LeetCode._0000_0999;

public class _0752_OpenLock
{
    /// <summary>
    /// https://leetcode.com/problems/open-the-lock
    /// </summary>
    public static int OpenLock(string[] deadends, string target)
    {
        var seen = deadends.ToHashSet();
        var q = new Queue<string>();
        if (!seen.Contains("0000"))
            q.Enqueue("0000");
        int res = 0;
        while (q.Count > 0)
        {
            for (int k = q.Count - 1; k >= 0; k--)
            {
                var cur = q.Dequeue();
                if (cur == target)
                    return res;
                var chs = cur.ToCharArray();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = -1; j <= 1; j += 2)
                    {
                        var next = chs.ToArray();
                        var temp = next[i] - '0';
                        next[i] = (char)((temp + j + 10) % 10 + '0');
                        var nextStr = new string(next);
                        if (!seen.Contains(nextStr))
                        {
                            seen.Add(nextStr);
                            q.Enqueue(nextStr);
                        }
                    }

                }
            }
            res++;
        }
        return -1;
    }
}
