namespace playground.LeetCode._3000_3999;

public class _3251_CountOfPairs
{
    public static int CountOfPairs(int[] nums)
    {
        int m = nums.Length, n = 1002;
        long MOD = (long)1e9 + 7;
        var memo = new long[m, n];
        for (int i = 0; i < m - 1; i++)
            for (int j = 0; j < n; j++)
                memo[i, j] = -1;
        for (int i = 0; i <= nums[m - 1]; i++)
            memo[m - 1, i] = nums[m - 1] + 1 - i;
        long Dfs(int i, int j)
        {
            if (memo[i, j] != -1)
                return memo[i, j];
            if (j > nums[i + 1])
                return memo[i, j] = 0;
            int next = Math.Max(j, nums[i + 1] - nums[i] + j);
            if (next >= n) return memo[i, j] = 0;
            memo[i, j] = Dfs(i + 1, next) + Dfs(i, j + 1);
            return memo[i, j] % MOD;
        }
        return (int)Dfs(0, 0);
    }
}
