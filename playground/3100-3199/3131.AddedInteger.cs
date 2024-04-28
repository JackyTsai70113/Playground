namespace playground;

public class AddedInteger3131
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-integer-added-to-array-i
    /// </summary>
    public static int AddedInteger(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        return nums2[0] - nums1[0];
    }
}
