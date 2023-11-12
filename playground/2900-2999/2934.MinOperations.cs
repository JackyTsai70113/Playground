namespace playground;

public class MinOperations_2934
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-maximize-last-elements-in-arrays
    /// </summary>
    public static int MinOperations(int[] nums1, int[] nums2)
    {
        int dp1 = 0, dp2 = 0;
        int mi = Math.Min(nums1[^1], nums2[^1]);
        int ma = Math.Max(nums1[^1], nums2[^1]);
        for (int i = 0; i < nums1.Length; ++i)
        {
            int a = nums1[i], b = nums2[i];
            if (Math.Min(a, b) > mi) return -1;
            if (nums1[^1] <= nums2[^1] && b > a && b > nums2[^1]) return -1;
            if (a > nums1[^1] || b > nums2[^1]) dp1++;
            if (a > nums2[^1] || b > nums1[^1]) dp2++;
        }
        return Math.Min(dp1, dp2);
    }
}
