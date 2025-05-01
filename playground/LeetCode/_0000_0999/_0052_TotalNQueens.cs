namespace playground.LeetCode._0000_0999;

public class _0052_TotalNQueens
{
    /// <summary>
    /// https://leetcode.com/problems/n-queens-ii
    /// </summary>
    public static int TotalNQueens(int n)
    {
        var res = new int[1];
        Bt(n, new List<int>(), res);
        return res[0];
    }

    static void Bt(int n, List<int> cur, int[] res)
    {
        if (cur.Count == n)
        {
            res[0]++;
            return;
        }
        for (int i = 0; i < n; i++)
        {
            bool valid = true;
            for (int j = 0; valid && j < cur.Count; j++)
            {
                if (cur[j] == i)
                    valid = false;
                else if (j + cur[j] == cur.Count + i)
                    valid = false;
                else if (j - cur[j] == cur.Count - i)
                    valid = false;
            }
            if (valid)
            {
                cur.Add(i);
                Bt(n, cur, res);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}
