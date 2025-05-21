namespace playground.LeetCode._2000_2999;

public class _2305_DistributeCookies
{
    public static int DistributeCookies(int[] cookies, int k)
    {
        var distribution = new int[k];
        int n = cookies.Length, res = int.MaxValue;
        void Dfs(int cookiesIdx)
        {
            if (cookiesIdx == n)
            {
                res = Math.Min(res, distribution.Max());
                return;
            }

            for (int i = 0; i < k; i++)
            {
                if (distribution[i] + cookies[cookiesIdx] > res)
                    continue;
                distribution[i] += cookies[cookiesIdx];
                Dfs(cookiesIdx + 1);
                distribution[i] -= cookies[cookiesIdx];
            }
        }
        Dfs(0);
        return res;
    }

    public static int DistributionCookies_Optimize(int[] cookies, int k)
    {
        int res = int.MaxValue;
        Dfs(cookies, k, new int[k], 0, k, ref res);
        return res;
    }

    static void Dfs(int[] cookies, int k, int[] cur, int i, int zeroCount, ref int res)
    {
        int n = cookies.Length;
        if (n - i < zeroCount) return;
        if (i == n)
        {
            res = Math.Min(res, cur.Max());
            return;
        }

        for (int j = 0; j < k; j++)
        {
            if (cur[j] + cookies[i] > res) continue;
            zeroCount -= cur[j] == 0 ? 1 : 0;
            cur[j] += cookies[i];
            Dfs(cookies, k, cur, i + 1, zeroCount, ref res);
            cur[j] -= cookies[i];
            zeroCount += cur[j] == 0 ? 1 : 0;
        }
    }
}
