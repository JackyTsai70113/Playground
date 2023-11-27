namespace playground;

public class FindMaximumLength_2945
{
    /// <summary>
    /// https://leetcode.com/problems/find-maximum-non-decreasing-array-length
    /// O(n^2)/O(n)
    /// </summary>
    public static int FindMaximumLength(int[] A)
    {
        int n = A.Length;
        long[] presum = new long[n + 1], last = new long[n + 1], dp = new long[n + 1];
        for (int i = 1; i <= n; ++i)
            last[i] = int.MaxValue;
        for (int j = 0; j < n; ++j)
        {
            presum[j + 1] = presum[j] + A[j];
            int i = j;
            while (last[i] > presum[j + 1] - presum[i]) i--;
            last[j + 1] = presum[j + 1] - presum[i];
            dp[j + 1] = dp[i] + 1;
        }
        return (int)dp[^1];
    }

    /// <summary>
    /// O(nlogn)/O(n)
    /// </summary>
    public static int FindMaximumLength2(int[] A)
    {
        int n = A.Length;
        var last = new long[n + 2];
        var presum = new long[n + 1];
        for (int i = 1; i <= n; i++)
            presum[i] = presum[i - 1] + A[i - 1];
        var dp = new long[n + 1];
        long ii = 0;
        for (int j = 0; j < n; ++j)
        {
            ii = Math.Max(ii, last[j + 1]);
            dp[j + 1] = dp[ii] + 1;
            int l = 0, r = presum.Length;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                // presum[j] - presum[i] <= presum[k] - presum[j]
                if (presum[m] >= presum[j + 1] * 2 - presum[ii])
                    r = m;
                else
                    l = m + 1;
            }
            last[l] = j + 1;
        }
        return (int)dp[^1];
    }
}
