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

    private static void MergeSort(int[] nums, int begin, int end)
    {
        if (begin >= end)
            return;
        int m = begin + (end - begin) / 2;
        MergeSort(nums, begin, m);
        MergeSort(nums, m + 1, end);
        Merge(nums, begin, end);
    }

    private static void Merge(int[] nums, int begin, int end)
    {
        int m = begin + (end - begin) / 2;
        var nums2 = new int[end - begin + 1];
        Array.Copy(nums, begin, nums2, 0, end - begin + 1);
        int i = 0, j = m + 1 - begin, k = begin;
        while (i <= m - begin || j <= end - begin)
        {
            int a = i <= m - begin ? nums2[i] : int.MaxValue;
            int b = j <= end - begin ? nums2[j] : int.MaxValue;
            nums[k++] = a < b ? nums2[i++] : nums2[j++];
        }
    }
}
