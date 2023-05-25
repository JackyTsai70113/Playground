namespace playground;

public class Solution
{
    /// <remarks>https://leetcode.com/problems/maximum-tastiness-of-candy-basket</remarks>
    public static int MaximumTastiness(int[] price, int k)
    {
        Array.Sort(price);
        var res = 0;
        for (int i = 0; i + k - 1 < price.Length; ++i)
        {
            res = Math.Max(res, price[i + k - 1] - price[i]);
        }
        return res;
    }

    /// <remarks>https://leetcode.com/problems/number-of-great-partitions</remarks>
    public static int CountPartitions(int[] nums, int k)
    {
        var res = new int[1];
        var sum = nums.Sum();
        Dfs(nums, sum, k, 0, 0, res);
        return res[0];
    }

    public static void Dfs(int[] nums, int sum, int k, int start, int cur, int[] res)
    {
        if (start == nums.Length)
        {
            if (cur >= k && sum - cur >= k)
            {
                res[0]++;
            }
            return;
        }
        cur += nums[start];
        Dfs(nums, sum, k, start + 1, cur, res);
        cur -= nums[start];
        Dfs(nums, sum, k, start + 1, cur, res);
    }
}