namespace playground.LeetCode._3000_3999;

public class _3129_NumberOfStableArrays
{
    public static int NumberOfStableArrays(int zero, int one, int limit)
    {
        int MOD = (int)1e9 + 7;
        var memo = new int[zero + 1, one + 1, 2];
        for (int i = 0; i <= zero; i++)
            for (int j = 0; j <= one; j++)
                for (int k = 0; k < 2; k++)
                    memo[i, j, k] = -1;
        int dfs(int zero, int one, int num, int limit)
        {
            if (zero == 0 && one == 0) return 1;
            if (memo[zero, one, num] != -1)
                return memo[zero, one, num];
            memo[zero, one, num] = 0;
            if (num == 0)
            {
                for (int i = 1; i <= Math.Min(zero, limit); i++)
                {
                    memo[zero, one, num] = (memo[zero, one, num] + dfs(zero - i, one, 1, limit)) % MOD;
                }
            }
            else
            {
                for (int i = 1; i <= Math.Min(one, limit); i++)
                {
                    memo[zero, one, num] = (memo[zero, one, num] + dfs(zero, one - i, 0, limit)) % MOD;
                }
            }
            return memo[zero, one, num];
        }
        return (dfs(zero, one, 0, limit) + dfs(zero, one, 1, limit)) % MOD;
    }
}
