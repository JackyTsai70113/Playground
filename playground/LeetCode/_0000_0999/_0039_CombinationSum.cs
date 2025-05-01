namespace playground.LeetCode._0000_0999;

public class _0039_CombinationSum
{
    public static IList<IList<int>> CombinationSum(int[] A, int target)
    {
        var res = new List<IList<int>>();
        Array.Sort(A);
        Bt(A, target, 0, new List<int>(), res);
        return res;
    }

    static void Bt(int[] A, int target, int start, List<int> cur, IList<IList<int>> res)
    {
        if (target == 0)
        {
            res.Add(new List<int>(cur));
            return;
        }

        for (int i = start; i < A.Length && A[i] <= target; ++i)
        {
            cur.Add(A[i]);
            Bt(A, target - A[i], i, cur, res);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}
