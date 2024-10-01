namespace playground_1000_1099;

public class _1031_MaxSumTwoNoOverlap
{
    public static int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
    {
        return Math.Max(Helper(nums, firstLen, secondLen), Helper(nums, secondLen, firstLen));
    }

    public static int Helper(int[] nums, int firstLen, int secondLen)
    {
        int n = nums.Length, res = 0;
        var dp = new int[n];
        for (int l = 0, r = 0, sum = 0; r < nums.Length; r++)
        {
            sum += nums[r];
            if (r >= firstLen - 1)
            {
                dp[r] = r == 0 ? sum : Math.Max(dp[r - 1], sum);
                sum -= nums[l];
                l++;
            }
        }
        for (int l = 0, r = 0, sum = 0; r < nums.Length; r++)
        {
            sum += nums[r];
            if (r >= secondLen - 1)
            {
                if (r >= firstLen + secondLen - 1)
                {
                    res = Math.Max(res, dp[l - 1] + sum);
                    // Console.WriteLine(l + " " + r + " " + dp[l-1] + " " + sum + " " + res);
                }
                sum -= nums[l];
                l++;
            }
        }
        return res;
    }
}
