namespace playground.Intervals;

public class MergeClass
{
    /// <summary>
    /// https://leetcode.com/problems/merge-intervals
    /// </summary>
    public static int[][] Merge(int[][] A)
    {
        Array.Sort(A, (x, y) => x[0] == y[0] ? x[1] - y[1] : x[0] - y[0]);
        var res = new List<int[]> { A[0] };
        for (int i = 1; i < A.Length; ++i)
        {
            if (res[^1][1] < A[i][0])
                res.Add(A[i]);
            else
                res[^1][1] = Math.Max(res[^1][1], A[i][1]);
        }
        return res.ToArray();
    }
}
