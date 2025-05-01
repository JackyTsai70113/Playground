namespace playground._1400_1499;

public class _1477_MinSumOfLengths_cs
{
    public static int MinSumOfLengths(int[] nums, int target)
    {
        int min = int.MaxValue, res = int.MaxValue;
        int n = nums.Length, sum = 0;
        // min len before index
        var dp = new int[n];
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            sum += nums[r];
            while (sum >= target)
            {
                if (sum == target)
                {
                    if (l > 0 && dp[l - 1] != int.MaxValue)
                    {
                        res = Math.Min(res, dp[l - 1] + (r - l + 1));
                    }
                    min = Math.Min(min, r - l + 1);
                }
                // update state by A[l]
                sum -= nums[l];
                l++;
            }
            dp[r] = r == 0 ? min : Math.Min(dp[r - 1], min);
        }
        return res == int.MaxValue ? -1 : res;
    }
}
