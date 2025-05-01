namespace playground;

public class _3224_MinChanges
{
    public static int MinChanges(int[] nums, int k)
    {
        int[] dp = new int[k + 1];
        int n = nums.Length;
        for (int i = 0; i < n / 2; i++)
        {
            if (nums[i] > nums[^(i + 1)])
                (nums[i], nums[^(i + 1)]) = (nums[^(i + 1)], nums[i]);
            int val = nums[^(i + 1)] - nums[i];
            for (int j = 0; j <= k; j++)
            {
                if (val == j) continue;
                if (nums[i] + j <= k || nums[^(i + 1)] - j >= 0)
                    dp[j]++;
                else
                    dp[j] += 2;
            }
        }
        return dp.Min();
    }
}
