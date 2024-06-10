namespace playground;

public class Intersect0350
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays-ii
    /// </summary>
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> d1 = new(), d2 = new();
        foreach (var num in nums1)
        {
            d1[num] = d1.ContainsKey(num) ? d1[num] + 1 : 1;
        }
        foreach (var num in nums2)
        {
            d2[num] = d2.ContainsKey(num) ? d2[num] + 1 : 1;
        }
        var res = new List<int>();
        foreach (var k in d1.Keys)
        {
            if(d2.ContainsKey(k)){
                var count = Math.Min(d1[k], d2[k]);
                res.AddRange(Enumerable.Repeat(k, count));
            }
        }
        return res.ToArray();
    }
}
