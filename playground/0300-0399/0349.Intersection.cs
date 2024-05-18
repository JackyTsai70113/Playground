namespace playground;

public class Intersection0349
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays
    /// </summary>
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        var set = nums1.ToHashSet();
        var res = new HashSet<int>();
        foreach (var num in nums2)
            if (set.Contains(num))
                res.Add(num);
        return res.ToArray();
    }
}
