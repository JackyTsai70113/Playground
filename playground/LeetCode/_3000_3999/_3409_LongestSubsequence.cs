namespace playground.LeetCode._3000_3999;

public class _3409_LongestSubsequence
{
    public static int LongestSubsequence(int[] nums)
    {
        int n = nums.Length, res = 0;
        var d = new Dictionary<(int index, int diff), int>();
        int Dfs(int index, int diff)
        {
            if (d.ContainsKey((index, diff)))
                return d[(index, diff)];
            int res = 1;
            for (int i = index + 1; i < n; i++)
            {
                int newDiff = Math.Abs(nums[index] - nums[i]);
                if (newDiff <= diff)
                {
                    res = Math.Max(res, 1 + Dfs(i, newDiff));
                }
            }
            return d[(index, diff)] = res;
        }
        for (int i = 0; i < n; i++)
        {
            res = Math.Max(res, Dfs(i, int.MaxValue));
        }
        return res;
    }
}
