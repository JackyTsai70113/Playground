namespace playground.LeetCode._0000_0999;

public class _0078_Subsets
{
    /// <summary>
    /// https://leetcode.com/problems/subsets
    /// </summary>
    public static IList<IList<int>> Subsets(int[] nums)
    {
        var res = new List<IList<int>>();
        for (int bit = 0; bit < (1 << nums.Length); bit++)
        {
            var cur = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if ((bit & (1 << i)) > 0)
                    cur.Add(nums[i]);
            }
            res.Add(cur);
        }
        return res;
    }

    public static IList<IList<int>> Subsets2(int[] nums)
    {
        var res = new List<IList<int>>();
        Dfs(nums, new List<int>(), 0, res);
        return res;
    }
    static void Dfs(int[] nums, List<int> cur, int start, List<IList<int>> res)
    {
        if (start == nums.Length)
        {
            res.Add(cur.ToList());
            return;
        }
        Dfs(nums, cur, start + 1, res);
        cur.Add(nums[start]);
        Dfs(nums, cur, start + 1, res);
        cur.RemoveAt(cur.Count - 1);
    }
}
