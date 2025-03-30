namespace playground;

public class SortArray0912
{
    /// <summary>
    /// https://leetcode.com/problems/sort-an-array
    /// </summary>
    public static int[] SortArray(int[] nums)
    {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private static void MergeSort(int[] nums, int l, int r)
    {
        if (l >= r) return;
        int m = l + (r - l) / 2;
        MergeSort(nums, l, m);
        MergeSort(nums, m + 1, r);
        Merge(nums, l, r);
    }

    private static void Merge(int[] nums, int l, int r)
    {
        int m = l + (r - l) / 2;
        var nums2 = new int[r - l + 1];
        Array.Copy(nums, l, nums2, 0, r - l + 1);
        int i = 0, j = m + 1 - l, k = l;
        while (k <= r)
        {
            int a = i <= m - l ? nums2[i] : int.MaxValue;
            int b = j <= r - l ? nums2[j] : int.MaxValue;
            nums[k++] = a < b ? nums2[i++] : nums2[j++];
        }
    }
}
