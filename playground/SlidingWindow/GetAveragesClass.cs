namespace playground.SlidingWindow;

public class GetAveragesClass
{
    /// <summary>
    /// https://leetcode.com/problems/k-radius-subarray-averages
    /// </summary>
    public static int[] GetAverages(int[] nums, int k)
    {
        int n = nums.Length;
        long sum = 0;
        var res = Enumerable.Repeat(-1, n).ToArray();
        for (int i = 0; i <= 2 * k && i < n; ++i)
        {
            sum += nums[i];
        }
        if (2 * k < n)
        {
            res[k] = (int)(sum / (2 * k + 1));
        }
        for (int i = 2 * k + 1; i < n; ++i)
        {
            sum += nums[i];
            sum -= nums[i - 2 * k - 1];
            res[i - k] = (int)(sum / (2 * k + 1));
        }
        return res;
    }
}
