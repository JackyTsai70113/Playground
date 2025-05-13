namespace playground.LeetCode._1000_1999;

public class _1291_SequentialDigits
{
    /// <summary>
    /// https://leetcode.com/problems/sequential-digits
    /// </summary>
    public static IList<int> SequentialDigits(int low, int high)
    {
        var res = new List<int>();
        Bt(low, high, new List<char>(), res);
        return res.OrderBy(x => x).ToList();
    }

    static void Bt(int low, int high, List<char> cur, List<int> res)
    {
        if (cur.Count > 0)
        {
            var num = int.Parse(new string(cur.ToArray()));
            if (low <= num && num <= high)
                res.Add(num);
            if (num > high || cur[^1] == '9')
                return;
        }
        if (cur.Count == 0)
        {
            for (char i = '1'; i <= '9'; i++)
            {
                cur.Add(i);
                Bt(low, high, cur, res);
                cur.RemoveAt(cur.Count - 1);
            }
        }
        else
        {
            cur.Add((char)(cur[^1] + 1));
            Bt(low, high, cur, res);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}
