using System.Numerics;

namespace playground;

public class CanSortArray3011
{
    /// <summary>
    /// https://leetcode.com/problems/find-if-array-can-be-sorted
    /// </summary>
    public static bool CanSortArray(int[] nums)
    {
        var bits = nums
            .Select(x => BitOperations.PopCount((uint)x))
            .ToArray();
        var ll = new List<List<int>>();
        var l2 = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (l2.Count > 0 && bits[l2[^1]] != bits[i])
            {
                ll.Add(new List<int>(l2));
                l2 = new List<int> { i };
            }
            else
            {
                l2.Add(i);
            }
        }
        ll.Add(new List<int>(l2));

        var max = int.MinValue;
        foreach (var l in ll)
        {
            var arr = l.Select(i => nums[i]).ToArray();
            var arr2 = l.Select(i => nums[i]).OrderBy(x => x).ToArray();
            if (arr2[0] < max) return false;
            max = arr2[^1];
        }
        return true;
    }
}
