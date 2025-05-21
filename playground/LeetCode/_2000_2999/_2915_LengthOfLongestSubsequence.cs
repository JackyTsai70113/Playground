using playground.BitManipulation;

namespace playground.LeetCode._2000_2999;

public class _2915_LengthOfLongestSubsequence
{
    // O(2^n) => TLE
    public static int LengthOfLongestSubsequence_TopDown(IList<int> nums, int target)
    {
        int n = nums.Count;
        var memo = new int[n, target];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < target; j++)
                memo[i, j] = -1;
        int Dfs(int i, int sum)
        {
            if (sum == target) return 0;

            // 算過且 invalid
            if (i == n) return int.MinValue;

            // 非 -1 表示算過了
            if (memo[i, sum] != -1) return memo[i, sum];

            // exclude nums[i]
            memo[i, sum] = Dfs(i + 1, sum);

            // include nums[i]
            if (sum + nums[i] <= target)
            {
                int next = Dfs(i + 1, sum + nums[i]);
                if (next != int.MinValue)
                    memo[i, sum] = Math.Max(memo[i, sum], 1 + next);
            }

            return memo[i, sum];
        }
        int res = Dfs(0, 0);
        return res == int.MinValue ? -1 : res;
    }

    public static int LengthOfLongestSubsequence_BottomUp(IList<int> nums, int target)
    {
        int[] dp = new int[target + 1];
        Array.Fill(dp, int.MinValue);
        dp[0] = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = target - nums[i]; j >= 0; j--)
            {
                dp[j + nums[i]] = Math.Max(dp[j + nums[i]], dp[j] + 1);
            }
        }
        return dp[target] > 0 ? dp[target] : -1;
    }
}
