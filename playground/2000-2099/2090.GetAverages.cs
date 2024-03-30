namespace playground;

public class GetAverages2090
{
    /// <summary>
    /// https://leetcode.com/problems/k-radius-subarray-averages
    /// </summary>
    public static int[] GetAverages(int[] nums, int k)
    {
        int n = nums.Length;
        long sum = 0;
        var res = Enumerable.Repeat(-1, n).ToArray();
        if (2 * k + 1 > n) return res;
        for (int i = 0; i <= k * 2 && i < nums.Length; i++)
        {
            sum += nums[i];
        }
        if(k * 2 < n) res[k] = (int)(sum / (2 * k + 1));
        for (int i = k * 2 + 1; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k * 2 - 1];
            res[i - k] = (int)(sum / (2 * k + 1));
        }
        return res;
    }
}
