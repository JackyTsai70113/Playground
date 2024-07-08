namespace playground;

public class CountRangeSum0327
{
    long[] sums;
    int lower;
    int upper;
    int res = 0;
    /// <summary>
    /// https://leetcode.com/problems/count-of-range-sum
    /// </summary>
    public int CountRangeSum(int[] nums, int lower, int upper)
    {
        int n = nums.Length;
        sums = new long[n + 1];
        for (int i = 1; i <= n; i++)
            sums[i] = nums[i - 1] + sums[i - 1];
        this.lower = lower;
        this.upper = upper;
        MergeSort(0, n);
        return res;
    }

    void MergeSort(int start, int end)
    {
        if (start == end)
        {
            return;
        }
        int mid = start + (end - start) / 2;
        MergeSort(start, mid);
        MergeSort(mid + 1, end);
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
    }
}
