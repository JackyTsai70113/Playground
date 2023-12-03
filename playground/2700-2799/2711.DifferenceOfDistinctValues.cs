namespace playground;

public class DifferenceOfDistinctValues_2711
{
    /// <summary>
    /// https://leetcode.com/problems/difference-of-number-of-distinct-values-on-diagonals
    /// </summary>
    public static int[][] DifferenceOfDistinctValues(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        HashSet<int> s1 = new(), s2 = new();
        int[][] res = new int[m][];
        for (int i = 0; i < m; ++i)
            res[i] = new int[n];
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                s1.Clear();
                s2.Clear();
                int p = i - 1, q = j - 1, x = i + 1, y = j + 1;
                while (p >= 0 && q >= 0) s1.Add(A[p--][q--]);
                while (x < m && y < n) s2.Add(A[x++][y++]);
                res[i][j] = Math.Abs(s1.Count - s2.Count);
            }
        }
        return res;
    }
}
