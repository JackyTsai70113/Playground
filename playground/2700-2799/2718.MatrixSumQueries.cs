namespace playground;

public class MatrixSumQueries2718
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-matrix-after-queries
    /// </summary>
    public static long MatrixSumQueries(int n, int[][] qs)
    {
        HashSet<int> r = new(), c = new();
        long res = 0;
        for (int i = qs.Length - 1; i >= 0; i--)
        {
            if (qs[i][0] == 0)
            {
                if (!r.Contains(qs[i][1]))
                {
                    res += qs[i][2] * (n - c.Count);
                    r.Add(qs[i][1]);
                }
            }
            else
            {
                if (!c.Contains(qs[i][1]))
                {
                    res += qs[i][2] * (n - r.Count);
                    c.Add(qs[i][1]);
                }
            }
        }
        return res;
    }
}
