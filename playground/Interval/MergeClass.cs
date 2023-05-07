namespace playground.Interval;

public class MergeClass
{
    public static int[][] Merge(int[][] A)
    {
        Array.Sort(A, (x, y) =>
        {
            if (x[0] != y[0])
            {
                return x[0] - y[0];
            }
            else
            {
                return x[1] - y[1];
            }
        });
        var res = new List<int[]>{A[0]};
        for (int i = 1; i < A.Length; ++i)
        {
            if (Interval.DoOverlap(res[^1], A[i]))
            {
                res[^1] = Interval.MergedIntervals(res[^1], A[i]);
            }
            else
            {
                res.Add(A[i]);
            }
        }
        return res.ToArray();
    }
}
