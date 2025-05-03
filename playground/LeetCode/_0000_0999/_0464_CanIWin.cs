namespace playground.LeetCode._0000_0999;

public class _0464_CanIWin
{
    public static bool CanIWin(int max, int desiredTotal)
    {
        if (max * (max + 1) / 2 < desiredTotal) return false;
        if (desiredTotal <= 0) return true;
        var memo = new bool?[(1 << (max + 1))];
        bool dfs(int choosed, int desiredTotal)
        {
            if (!memo[choosed].HasValue)
            {
                memo[choosed] = false;
                for (int i = 1; i <= max; i++)
                {
                    if ((choosed & (1 << i)) == 0)
                    {
                        if (i >= desiredTotal || !dfs(choosed | 1 << i, desiredTotal - i))
                        {
                            memo[choosed] = true;
                            break;
                        }
                    }
                }
            }
            return memo[choosed].Value;
        }
        return dfs(0, desiredTotal);
    }
}
