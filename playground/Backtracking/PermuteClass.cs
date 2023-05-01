namespace playground.Backtracking;

public class PermuteClass
{
    public static IList<IList<int>> Permute(int[] nums)
    {
        var res = new List<IList<int>>();
        Bt(nums, 0, nums.ToArray(), res);
        return res;
    }

    static void Bt(int[] nums, int start, int[] cur, IList<IList<int>> res)
    {
        if (start >= nums.Length)
        {
            res.Add(new List<int>(cur));
            return;
        }
        for (int i = start; i < nums.Length; ++i)
        {
            (cur[start], cur[i]) = (cur[i], cur[start]);
            Bt(nums, start + 1, cur, res);
            (cur[start], cur[i]) = (cur[i], cur[start]);
        }
    }
}
