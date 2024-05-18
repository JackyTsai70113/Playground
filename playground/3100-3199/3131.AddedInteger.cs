namespace playground;

public class AddedInteger3131
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-integer-added-to-array-i
    /// </summary>
    public static int AddedInteger(int[] nums1, int[] nums2)
    {
        int a = 1000, b = 1000;
        foreach (var num in nums1)
            a = Math.Min(a, num);
        foreach (var num in nums2)
            b = Math.Min(b, num);
        return b - a;
    }
}
