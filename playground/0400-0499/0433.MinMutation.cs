namespace playground;

public class MinMutation0433
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-genetic-mutation
    /// </summary>
    public static int MinMutation(string start, string end, string[] bank)
    {
        var set = bank.ToHashSet();
        if (!set.Contains(end))
            return -1;
        var genes = new char[] { 'A', 'C', 'G', 'T' };
        int step = 0;
        Queue<string> q = new();
        q.Enqueue(start);
        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; --i)
            {
                string u = q.Dequeue();
                if (u == end)
                    return step;
                var chs = u.ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    var temp = chs[j];
                    foreach (var c in genes)
                    {
                        if (temp == c)
                            continue;
                        chs[j] = c;
                        var str = new string(chs);
                        if (!set.Contains(str))
                            continue;
                        set.Remove(str);
                        q.Enqueue(str);
                    }
                    chs[j] = temp;
                }
            }
            step++;
        }
        return -1;
    }
}
