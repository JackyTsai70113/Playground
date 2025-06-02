namespace playground.LeetCode._1000_1999;

public class _1191_KConcatenationMaxSum
{
    public static int KConcatenationMaxSum(int[] arr, int k)
    {
        int n = arr.Length;
        long subSum = int.MinValue, maxSubsum = 0;
        long MOD = (long)1e9 + 7;
        long totalSum = 0;

        long prefixSum = 0, maxPrefix = 0;
        long suffixSum = 0, maxSuffix = 0;
        for (int i = 0; i < n; i++)
        {
            totalSum += arr[i];

            subSum = Math.Max(arr[i], subSum + arr[i]);
            maxSubsum = Math.Max(maxSubsum, subSum);

            prefixSum += arr[i];
            maxPrefix = Math.Max(maxPrefix, prefixSum);
        }

        if (k == 1)
            return (int)(maxSubsum % MOD);

        for (int i = n - 1; i >= 0; i--)
        {
            suffixSum += arr[i];
            maxSuffix = Math.Max(maxSuffix, suffixSum);
        }

        long maxSum = Math.Max(maxSubsum, maxPrefix + maxSuffix) % MOD;
        if (totalSum > 0)
            maxSum = (maxSum + totalSum * (k - 2)) % MOD;
        return (int)maxSum;
    }
}