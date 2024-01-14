namespace playground;

public class MaximumSetSize3002
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-size-of-a-set-after-removals
    /// </summary>
    public static int MaximumSetSize(int[] nums1, int[] nums2)
    {
        int n = nums1.Length;
        var s3 = nums1.Intersect(nums2);
        var s1 = nums1.Except(s3);
        var s2 = nums2.Except(s3);
        var a = Math.Min(s1.Count(), n / 2);
        var b = Math.Min(s2.Count(), n / 2);
        var c = Math.Min(s3.Count(), n - a - b);
        return a + b + c;
    }
}
