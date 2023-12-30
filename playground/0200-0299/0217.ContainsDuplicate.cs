namespace playground;

public class ContainsDuplicate0217
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
