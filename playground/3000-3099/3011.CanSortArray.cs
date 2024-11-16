using System.Numerics;

namespace playground;

public class CanSortArray3011
{
    public static bool CanSortArray(int[] nums)
    {
        var l = new List<int> { nums[0] };
        var l2 = new List<int>();
        for (int i = 1; i < nums.Length; i++)
        {
            if (BitOperations.PopCount((uint)nums[i - 1]) == BitOperations.PopCount((uint)nums[i]))
            {
                l.Add(nums[i]);
            }
            else
            {
                l.Sort();
                l2.AddRange(l);
                l = new List<int> { nums[i] };
            }
        }
        l.Sort();
        l2.AddRange(l);
        for (int i = 1; i < l2.Count; i++)
        {
            if (l2[i - 1] > l2[i])
                return false;
        }
        return true;
    }
}
