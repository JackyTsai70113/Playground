namespace playground.LeetCode._0000_0999;

public class _0493_ReversePairs
{
    public static int ReversePairs(int[] nums)
    {
        return MergeSort(nums, 0, nums.Length - 1);
    }

    private static int MergeSort(int[] nums, int left, int right)
    {
        if (left >= right) return 0;

        int mid = left + (right - left) / 2;
        int count = MergeSort(nums, left, mid) + MergeSort(nums, mid + 1, right);

        int[] merged = new int[right - left + 1];
        int idx = 0, l = left, r = mid + 1, r2 = mid + 1;
        while (l <= mid)
        {
            while (r2 <= right && nums[l] > 2L * nums[r2]) r2++;
            count += r2 - mid - 1;
            while (r <= right && nums[l] > nums[r]) merged[idx++] = nums[r++];
            merged[idx++] = nums[l++];
        }
        while (r <= right) merged[idx++] = nums[r++];
        Array.Copy(merged, 0, nums, left, merged.Length);
        return count;
    }
}
