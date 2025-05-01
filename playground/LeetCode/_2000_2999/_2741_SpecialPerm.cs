namespace playground.LeetCode._2000_2999;

public class _2741_SpecialPerm
{
    /// <summary>
    /// https://leetcode.com/problems/special-permutations
    /// </summary>
    public static int SpecialPerm(int[] nums)
    {
        int n = nums.Length, MOD = (int)1e9 + 7, res = 0;
        var memo = new int[n, 1 << n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < (1 << n); j++)
                memo[i, j] = -1;
        for (int i = 0; i < n; i++)
            res = (res + Dfs(nums, i, 1 << i, MOD, memo)) % MOD;
        return (int)res;
    }

    static int Dfs(int[] nums, int start, int mask, int MOD, int[,] memo)
    {
        if (mask == (1 << nums.Length) - 1)
            return 1;
        if (memo[start, mask] != -1)
            return memo[start, mask];
        var res = 0;
        for (int i = 0; i < nums.Length; i++)
            if ((mask & (1 << i)) == 0 && (nums[i] % nums[start] == 0 || nums[start] % nums[i] == 0))
                res = (res + Dfs(nums, i, mask | 1 << i, MOD, memo)) % MOD;
        return memo[start, mask] = res;
    }
}
