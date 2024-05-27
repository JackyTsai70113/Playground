namespace playground;

public class BeautifulSubsets2597
{
    /// <summary>
    /// https://leetcode.com/problems/the-number-of-beautiful-subsets
    /// </summary>
    public static int BeautifulSubsets(int[] nums, int k)
    {
        Array.Sort(nums);
        return Bt(nums, k, 0, new List<int>()) - 1;
    }

    static int Bt(int[] nums, int k, int start, List<int> cur)
    {
        if (start == nums.Length)
            return 1;
        var res = 0;
        if (cur.Count == 0 || !cur.Contains(nums[start] - k))
        {
            cur.Add(nums[start]);
            res += Bt(nums, k, start + 1, cur);
            cur.RemoveAt(cur.Count - 1);
        }
        res += Bt(nums, k, start + 1, cur);
        return res;
    }
}
