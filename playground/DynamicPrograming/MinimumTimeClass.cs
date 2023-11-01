using Microsoft.Win32.SafeHandles;

namespace playground.DynamicPrograming;

public class MinimumTimeClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-to-make-array-sum-at-most-x
    /// </summary>
    public static int MinimumTime(IList<int> nums1, IList<int> nums2, int x)
    {
        if (nums1.Sum() <= x) return 0;
        int n = nums1.Count, sum1 = nums1.Sum(), sum2 = nums2.Sum();
        var dp = new int[n + 1];
        var ba = new int[n][];
        for (int i = 0; i < n; ++i)
            ba[i] = new int[] { nums2[i], nums1[i] };
        Array.Sort(ba, (x, y) => x[0] - y[0]);
        for (int i = 0; i < n; ++i)
            for (int j = i + 1; j > 0; --j)
                dp[j] = Math.Max(dp[j], dp[j - 1] + j * ba[i][0] + ba[i][1]);
        for (int i = 0; i <= n; ++i)
            if (sum1 + i * sum2 - dp[i] <= x)
                return i;
        return -1;
    }
}
