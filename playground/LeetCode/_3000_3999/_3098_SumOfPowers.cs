namespace playground;

public class _3098_SumOfPowers
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-sum-of-subsequence-powers
    /// </summary>
    public static int SumOfPowers(int[] nums, int k)
    {
        Array.Sort(nums);
        int n = nums.Length, MOD = (int)1e9 + 7;
        var d = new Dictionary<(int, int, int, int), int>();
        int dfs(int ipre, int icur, int minDiff, int remain)
        {
            if (remain == 0) return minDiff;
            if (n - icur < remain) return 0;
            if (d.ContainsKey((ipre, icur, minDiff, remain)))
                return d[(ipre, icur, minDiff, remain)];
            int take;
            if (ipre == -1)
            {
                take = dfs(icur, icur + 1, minDiff, remain - 1);
            }
            else
            {
                take = dfs(icur, icur + 1, Math.Min(minDiff, nums[icur] - nums[ipre]), remain - 1);
            }
            int noTake = dfs(ipre, icur + 1, minDiff, remain);
            return d[(ipre, icur, minDiff, remain)] = (take + noTake) % MOD;
        }
        return dfs(-1, 0, int.MaxValue, k);
    }
}
