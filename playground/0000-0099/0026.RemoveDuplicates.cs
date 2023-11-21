namespace playground;

public class RemoveDuplicates_0026
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array
    /// </summary>
    public static int RemoveDuplicates(int[] nums)
    {
        var set = new HashSet<int>();
        var l = new List<int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (!set.Contains(nums[i]))
            {
                set.Add(nums[i]);
                l.Add(nums[i]);
            }
        }
        for (int i = 0; i < l.Count; ++i)
        {
            nums[i] = l[i];
        }
        return l.Count;
    }
}
