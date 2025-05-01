namespace playground.LeetCode._0000_0999;

public class _0077_Combine
{
    /// <summary>
    /// https://leetcode.com/problems/combinations
    /// </summary>
    public static IList<IList<int>> Combine(int n, int k)
    {
        var res = new List<IList<int>>();
        Bt(n, k, 1, new List<int>(), res);
        return res;
    }

    static void Bt(int n, int k, int start, List<int> cur, List<IList<int>> res)
    {
        if (cur.Count == k)
        {
            res.Add(new List<int>(cur));
            return;
        }

        for (int i = start; i <= n; i++)
        {
            cur.Add(i);
            Bt(n, k, i + 1, cur, res);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}
