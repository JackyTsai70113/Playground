namespace playground.LeetCode._0000_0999;

public class _0217_ContainsDuplicate
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate
    /// </summary>
    public static bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            if (set.Contains(num))
                return true;
            set.Add(num);
        }
        return false;
    }
}
