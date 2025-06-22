namespace playground.LeetCode._3000_3999;

public class _3592_FindCoins
{
    public static IList<int> FindCoins(int[] numWays)
    {
        int n = numWays.Length;
        List<int> recoveredDenominations = new();
        long[] dp = new long[n + 1];
        dp[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            long targetWays = numWays[i - 1];

            if (targetWays < dp[i])
            {
                return Array.Empty<int>();
            }

            if (targetWays > dp[i])
            {
                if (targetWays - dp[i] != 1)
                {
                    return Array.Empty<int>();
                }

                recoveredDenominations.Add(i);

                for (int j = i; j <= n; j++)
                {
                    dp[j] += dp[j - i];
                }
            }
        }

        return recoveredDenominations.ToArray();
    }
}
