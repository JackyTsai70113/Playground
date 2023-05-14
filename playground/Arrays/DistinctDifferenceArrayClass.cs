namespace playground.Arrays;

public class DistinctDifferenceArrayClass
{
    /// <remarks>https://leetcode.com/problems/find-the-distinct-difference-array/</remarks>
    public static int[] DistinctDifferenceArray(int[] nums)
    {
        var s = new HashSet<int>();
        var d2 = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            d2[num] = d2.ContainsKey(num) ? d2[num] + 1 : 1;
        }

        var res = new int[nums.Length];
        for (int i = 0; i < nums.Length; ++i)
        {
            s.Add(nums[i]);
            if (--d2[nums[i]] == 0) d2.Remove(nums[i]);
            res[i] = s.Count - d2.Keys.Count;
        }
        return res;
    }
}
