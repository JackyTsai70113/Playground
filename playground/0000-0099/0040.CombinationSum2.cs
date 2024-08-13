namespace playground;

public class CombinationSum20040
{
    public static IList<IList<int>> CombinationSum2(int[] A, int target)
    {
        Array.Sort(A);
        var res = new List<IList<int>>();
        Bt(A, target, 0, new List<int>(), res);
        return res;
    }

    static void Bt(int[] A, int target, int start, List<int> cur, List<IList<int>> res)
    {
        if (target < 0) return;
        if (target == 0)
        {
            res.Add(new List<int>(cur));
            return;
        }
        for (int i = start; i < A.Length; i++)
        {
            if (i != start && A[i - 1] == A[i])
                continue;
            cur.Add(A[i]);
            Bt(A, target - A[i], i + 1, cur, res);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}
