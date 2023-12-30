namespace playground;

public class ContainsNearbyDuplicate0219
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate-ii/
    /// </summary>
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var d = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (d.ContainsKey(nums[i]) && i - d[nums[i]] <= k)
                return true;
            d[nums[i]] = i;
        }
        return false;
    }
}
