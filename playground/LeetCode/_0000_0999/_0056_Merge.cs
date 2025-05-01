namespace playground.LeetCode._0000_0999;

public class _0056_Merge
{
    public static int[][] Merge(int[][] A)
    {
        Array.Sort(A, (x, y) => x[0] - y[0]);
        var res = new List<int[]> { A[0] };
        foreach (var a in A)
        {
            if (res[^1][1] >= a[0])
                res[^1][1] = Math.Max(res[^1][1], a[1]);
            else
                res.Add(a);
        }
        return res.ToArray();
    }
}