namespace playground.LeetCode._0000_0999;

public class _0526_CountArrangement
{
    /// <summary>
    /// https://leetcode.com/problems/beautiful-arrangement
    /// </summary>
    public static int CountArrangement(int n)
    {
        return Dfs(n, (1 << n) - 1, 0);
    }

    private static int Dfs(int n, int mask, int start)
    {
        if (start == n) return 1;
        var res = 0;
        for (int i = 0; i < n; i++)
        {
            if (((mask >> i) & 1) > 0 &&
                ((i + 1) % (start + 1) == 0 || (start + 1) % (i + 1) == 0))
            {
                res += Dfs(n, mask ^ (1 << i), start + 1);
            }
        }
        return res;
    }
}
