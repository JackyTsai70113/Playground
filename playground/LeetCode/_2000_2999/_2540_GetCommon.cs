namespace playground.LeetCode._2000_2999;

public class _2540_GetCommon
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-common-value
    /// </summary>
    public static int GetCommon(int[] nums1, int[] nums2)
    {
        int i = 0, j = 0;
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
            {
                return nums1[i];
            }
            else if (nums1[i] < nums2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        return -1;
    }
}
