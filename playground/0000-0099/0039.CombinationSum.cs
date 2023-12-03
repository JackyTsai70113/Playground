namespace playground;

public class CombinationSum_0039
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum
    /// </summary>
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
