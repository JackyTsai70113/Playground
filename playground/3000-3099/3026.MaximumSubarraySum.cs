namespace playground;

public class MaximumSubarraySum3026
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-good-subarray-sum
    /// </summary>
    public static long MaximumSubarraySum(int[] A, int k)
    {
        int n = A.Length;
        long res = int.MinValue;
        var presum = new long[n];
        for (int i = 0; i < n; i++)
            presum[i] = presum[i] + A[i] + (i == 0 ? 0 : presum[i - 1]);
        var d = new Dictionary<int, long>();
        for (int i = 0; i < n; i++)
        {
            if (d.ContainsKey(A[i] - k))
            {
                res = Math.Max(res, presum[i] - d[A[i] - k] + A[i] - k);
            }
            if (d.ContainsKey(A[i] + k))
            {
                res = Math.Max(res, presum[i] - d[A[i] + k] + A[i] + k);
            }
            d[A[i]] = d.ContainsKey(A[i]) ? Math.Min(d[A[i]], presum[i]) : presum[i];
        }
        return res == int.MinValue ? 0 : res;
    }
}
