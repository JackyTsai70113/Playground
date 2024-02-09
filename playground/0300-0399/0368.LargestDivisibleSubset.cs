namespace playground;

public class LargestDivisibleSubset0368
{
    /// <summary>
    /// https://leetcode.com/problems/largest-divisible-subset
    /// </summary>
    public static IList<int> LargestDivisibleSubset(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length, maxLength = 1, maxIndex = 0;
        List<int> res = new();
        var dp = new int[n];
        Array.Fill(dp, 1);
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0)
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
                maxIndex = i;
            }
        }
        for (int i = maxIndex; i >= 0; i--)
        {
            if (nums[maxIndex] % nums[i] == 0 && dp[i] == maxLength)
            {
                res.Add(nums[i]);
                maxIndex = i;
                maxLength--;
            }
        }
        return res;
    }
}
