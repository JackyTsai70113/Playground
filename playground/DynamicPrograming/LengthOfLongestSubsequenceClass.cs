namespace playground.DynamicPrograming;

public class LengthOfLongestSubsequenceClass
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-the-longest-subsequence-that-sums-to-target
    /// </summary>
    public static int LengthOfLongestSubsequence(IList<int> nums, int target)
    {
        var memo = new int[target + 1];
        for (int i = 0; i < nums.Count; ++i)
        {
            for (int j = target - nums[i]; j >= 0; --j)
            {
                if (j == 0 || memo[j] > 0)
                {
                    memo[j + nums[i]] = Math.Max(memo[j + nums[i]], memo[j] + 1);
                }
            }
        }
        return memo[target] == 0 ? -1 : memo[target];
    }
}
