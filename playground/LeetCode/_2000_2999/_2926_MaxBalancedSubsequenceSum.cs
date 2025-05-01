namespace playground.LeetCode._2000_2999;

public class _2926_MaxBalancedSubsequenceSum
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-balanced-subsequence-sum
    /// </summary>
    public static long MaxBalancedSubsequenceSum(int[] nums)
    {
        var memo = new SortedDictionary<int, long>
        {
            [int.MinValue] = 0
        };
        List<int> keys;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] <= 0) continue;
            keys = memo.Keys.ToList();
            int l = 0, r = keys.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (keys[m] <= nums[i] - i)
                    l = m + 1;
                else
                    r = m;
            }
            long sum = memo[keys[l - 1]] + nums[i];
            memo[nums[i] - i] = sum;
            for (int j = l; j < keys.Count && memo[keys[j]] <= sum; ++j)
            {
                memo.Remove(keys[j]);
            }
        }
        return memo.Keys.Count > 1 ? memo[memo.Keys.Last()] : nums.Max();
    }
}
