namespace playground.LeetCode._1000_1999;

public class _1508_RangeSum
{
    public static int RangeSum(int[] nums, int n, int left, int right)
    {
        int[] arr = new int[n * (n + 1) / 2];
        for (int i = 0, k = 0; i < n; ++i)
        {
            for (int j = i, sum = 0; j < n; ++j)
            {
                sum += nums[j];
                arr[k++] = sum;
            }
        }
        Array.Sort(arr);
        int ans = 0;
        int mod = (int)1e9 + 7;
        for (int i = left - 1; i < right; ++i)
        {
            ans = (ans + arr[i]) % mod;
        }
        return ans;
    }

    long maxSum;
    long minSum;
    public int RangeSum2(int[] nums, int n, int left, int right)
    {
        int MOD = (int)1e9 + 7;
        maxSum = 0;
        minSum = nums[0];
        foreach (var num in nums)
        {
            maxSum += num;
            minSum = Math.Min(minSum, num);
        }
        return (int)((MOD + SumOfFirstKSubArray(nums, right) % MOD - SumOfFirstKSubArray(nums, left - 1) % MOD) % MOD);
    }

    /// <summary>
    /// 取得不大於 targetSum 的 subarray 數量及其 sum 總和
    /// </summary>
    private static (int count, long totalSum) CountAndTotalSumBelowTargetSum(int[] nums, long targetSum)
    {
        int n = nums.Length;
        int count = 0;
        long totalSum = 0, accumulatedSum = 0, curSum = 0;
        for (int l = 0, r = 0; r < n; r++)
        {
            accumulatedSum += (long)nums[r] * (r - l + 1);
            curSum += nums[r];
            while (curSum > targetSum)
            {
                accumulatedSum -= curSum;
                curSum -= nums[l++];
            }
            totalSum += accumulatedSum;
            count += r - l + 1;
        }
        return (count, totalSum);
    }

    /// <summary>
    /// 取得 前 k 個 以 subarray sum 排序的 subarray sum 總和
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    ///            0 1 2 3
    ///            -------
    /// nums[i]:   2 2 2 2
    /// 
    ///               1 2 3 4 5 6 7 8 9 10
    ///               -------------------
    /// subarray sum: 2 2 2 2 4 4 4 6 6 8
    /// SumOfFirstKSubArray(nums, k:8): leftSum = 6, (count: 9, sum = 2+2+2+2+4+4+4+6+6)
    ///     => sum - leftSum*(count-k) => sum - 6*(9-8)
    /// </remarks>
    private long SumOfFirstKSubArray(int[] nums, int k)
    {
        long leftSum = minSum, rightSum = maxSum;
        while (leftSum < rightSum)
        {
            long m = leftSum + (rightSum - leftSum) / 2;
            if (CountAndTotalSumBelowTargetSum(nums, m).count >= k)
            {
                rightSum = m;
            }
            else
            {
                leftSum = m + 1;
            }
        }
        (int count, long totalSum) = CountAndTotalSumBelowTargetSum(nums, leftSum);
        return totalSum - leftSum * (count - k);
    }
}
