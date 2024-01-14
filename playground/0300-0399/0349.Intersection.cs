namespace playground;

public class Intersection0349
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays
    /// </summary>
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        return nums1.ToHashSet().Intersect(nums2.ToHashSet()).ToArray();
    }
}
