namespace playground.LeetCode._3000_3999;

public class _3538_MinTravelTime
{
    public static int MinTravelTime(int l, int n, int k, int[] ps, int[] ts)
    {
        var prefix = new int[n];
        prefix[0] = ts[0];
        for (int i = 1; i < n - 1; i++)
            prefix[i] = prefix[i - 1] + ts[i];

        int steps = n - k;
        var dp = new int[k + 1, n, n + 1];
        int Dfs(int k, int i, int last)
        {
            if (i == n - 1)
            {
                return k == 0 ? 0 : int.MaxValue;
            }

            if (dp[k, i, last] != 0)
            {
                return dp[k, i, last];
            }
            dp[k, i, last] = int.MaxValue;
            int time = prefix[i] - (last > 0 ? prefix[last - 1] : 0);
            int till = Math.Min(n - 1, i + k + 1);
            for (int j = i + 1; j <= till; j++)
            {
                int dist = ps[j] - ps[i];
                int next = Dfs(k - (j - i - 1), j, i + 1);
                if (next != int.MaxValue)
                {
                    dp[k, i, last] =
                        Math.Min(
                            dp[k, i, last],
                            dist * time + next);
                }
            }
            return dp[k, i, last];
        }
        return Dfs(k, 0, 0);
    }

    public static int MinTravelTime2(int psLength, int n, int k, int[] ps, int[] ts)
    {
        var prefix = new int[n + 1];
        for (int i = 0; i < n; i++)
            prefix[i + 1] = prefix[i] + ts[i];

        var dp = new int[n + 1, n + 1, n + 1];
        int dfs(int l, int r, int remain)
        {
            if (r == n - 1)
                return remain == 0 ? 0 : int.MaxValue;
            if (remain == -1)
                return int.MaxValue;

            if (dp[l, r, remain] != 0)
                return dp[l, r, remain];

            int rate = prefix[r + 1] - prefix[l];
            int res = int.MaxValue;
            for (int i = r + 1; i <= Math.Min(n - 1, n - remain); i++)
            {
                int dist = ps[i] - ps[r];
                int next = dfs(r + 1, i, remain - 1);
                if (next != int.MaxValue)
                    res = Math.Min(res, dist * rate + next);
            }
            return dp[l, r, remain] = res;
        }

        return dfs(0, 0, n - k - 1);
    }
}
