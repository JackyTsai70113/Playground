using System.Numerics;

namespace playground;

public class _3149_FindPermutation
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-minimum-cost-array-permutation
    /// </summary>
    public static int[] FindPermutation(int[] nums)
    {
        int n = nums.Length;
        var memo = new (int val, int score)[nums.Length, 1 << n];
        for (int i = 0; i < nums.Length; i++)
            for (int j = 0; j < (1 << n); j++)
                memo[i, j] = (-1, -1);
        Dfs(nums, 0, 1, memo);
        var res = new List<int> { 0 };
        for (int mask = 1; BitOperations.PopCount((uint)mask) < n; mask |= 1 << res[^1])
        {
            res.Add(memo[res[^1], mask].val);
        }
        return res.ToArray();
    }

    static int Dfs(int[] nums, int cur, int mask, (int val, int score)[,] memo)
    {
        if (BitOperations.PopCount((uint)mask) == nums.Length)
            return Math.Abs(cur - nums[0]);
        if (memo[cur, mask].score >= 0)
            return memo[cur, mask].score;
        memo[cur, mask] = (int.MaxValue, int.MaxValue);
        for (int i = 1; i < nums.Length; i++)
        {
            if ((mask & (1 << i)) > 0)
                continue;
            var newScore = Math.Abs(cur - nums[i]) + Dfs(nums, i, mask | (1 << i), memo);
            if (newScore < memo[cur, mask].score)
            {
                memo[cur, mask] = (i, newScore);
            }
        }
        return memo[cur, mask].score;
    }
}
