namespace playground;

public class Permute0046
{
    /// <summary>
    /// https://leetcode.com/problems/permutations
    /// </summary>
    public static IList<IList<int>> Permute(int[] nums)
    {
        var res = new List<IList<int>>();
        Bt(nums, new HashSet<int>(), res);
        return res;
    }

    static void Bt(int[] nums, HashSet<int> cur, IList<IList<int>> res)
    {
        if (cur.Count == nums.Length)
        {
            res.Add(cur.ToList());
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (!cur.Contains(nums[i]))
            {
                cur.Add(nums[i]);
                Bt(nums, cur, res);
                cur.Remove(nums[i]);
            }
        }
    }
}
