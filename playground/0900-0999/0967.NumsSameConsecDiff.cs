namespace playground;

public class NumsSameConsecDiff0967
{
    /// <summary>
    /// https://leetcode.com/problems/numbers-with-same-consecutive-differences
    /// </summary>
    public static int[] NumsSameConsecDiff(int n, int k)
    {
        List<int> res = new();
        void dfs(int n, int cur)
        {
            if (n == 0)
            {
                res.Add(cur);
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                if (cur == 0 && i > 0)
                    dfs(n - 1, i);
                if (cur > 0 && (cur % 10 + k == i || cur % 10 - k == i))
                    dfs(n - 1, cur * 10 + i);
            }
        }
        dfs(n, 0);
        return res.ToArray();
    }

    public static int[] NumsSameConsecDiff2(int n, int k)
    {
        List<int> res = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 1; i < n; i++)
        {
            List<int> cur = new();
            foreach (var x in res)
            {
                if (x % 10 - k >=0) cur.Add(x * 10 + x % 10 - k);
                if (k != 0 && x % 10 + k <10) cur.Add(x * 10 + x % 10 + k);
            }
            res = cur;
        }
        return res.ToArray();
    }
}
