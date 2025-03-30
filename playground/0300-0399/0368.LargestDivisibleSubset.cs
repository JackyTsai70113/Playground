namespace playground;

public class _0368_LargestDivisibleSubset
{
    public static IList<int> LargestDivisibleSubset(int[] nums)
    {
        Array.Sort(nums);
        int maxLen = 0, maxIndex = 0;
        var dp = new int[nums.Length];
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0 && dp[i] < dp[j] + 1)
                {
                    dp[i] = dp[j] + 1;
                }
            }
            if (maxLen < dp[i])
            {
                maxLen = dp[i];
                maxIndex = i;
            }
        }
        var res = new List<int>();
        for (int i = maxIndex; i >= 0; i--)
        {
            if (nums[maxIndex] % nums[i] == 0 && dp[i] == maxLen)
            {
                res.Add(nums[i]);
                maxIndex = i;
                maxLen--;
            }
        }
        return res;
    }
}
