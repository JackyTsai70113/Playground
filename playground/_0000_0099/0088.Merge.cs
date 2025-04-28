namespace playground;

public class Merge_0088
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array
    /// </summary>
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int idx1 = m - 1, idx2 = n - 1, i = m + n - 1;
        while (idx2 >= 0)
        {
            if (idx1 >= 0 && nums1[idx1] > nums2[idx2])
                nums1[i--] = nums1[idx1--];
            else
                nums1[i--] = nums2[idx2--];
        }
    }
}
