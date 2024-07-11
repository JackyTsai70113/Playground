namespace playground;

public class CountRangeSum0327
{
    /// <summary>
    /// https://leetcode.com/problems/count-of-range-sum
    /// </summary>
    public static int CountRangeSum(int[] nums, int lower, int upper)
    {
        int n = nums.Length;
        var sums = new long[n + 1];
        for (int i = 0; i < n; i++) sums[i + 1] = nums[i] + sums[i];
        int res = MergeSort(sums, lower, upper, 0, n);
        return res;
    }

    static int MergeSort(long[] sums, int lower, int upper, int start, int end)
    {
        if (start == end) return 0;
        int mid = start + (end - start) / 2;
        int res = MergeSort(sums, lower, upper, start, mid) + MergeSort(sums, lower, upper, mid + 1, end);
        var memo = new long[end - start + 1];
        int j = mid + 1, k = mid + 1, t = mid + 1;
        for (int i = start, r = 0; i <= mid; i++, r++)
        {
            while (j <= end && sums[j] - sums[i] < lower) j++;
            while (k <= end && sums[k] - sums[i] <= upper) k++;
            while (t <= end && sums[t] < sums[i]) memo[r++] = sums[t++];
            memo[r] = sums[i];
            res += k - j;
        }
        Array.Copy(memo, 0, sums, start, t - start);
        return res;
    }
}
