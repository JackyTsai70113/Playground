namespace playground.LeetCode._2000_2999;

public class _2670_DistinctDifferenceArray
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-distinct-difference-array
    /// </summary>
    public static int[] DistinctDifferenceArray(int[] nums)
    {
        HashSet<int> s = new(), s2 = new();
        var res = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            s.Add(nums[i]);
            res[i] += s.Count;
            res[^(i + 1)] -= s2.Count;
            s2.Add(nums[^(i + 1)]);
        }
        return res;
    }
}
