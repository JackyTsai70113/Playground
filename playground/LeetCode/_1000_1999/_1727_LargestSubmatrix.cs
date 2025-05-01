namespace playground;

public class _1727_LargestSubmatrix
{
    /// <summary>
    /// https://leetcode.com/problems/largest-submatrix-with-rearrangements
    /// </summary>
    public static int LargestSubmatrix(int[][] A)
    {
        int m = A.Length, n = A[0].Length, res = 0;
        for (int i = 1; i < m; ++i)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i - 1][j] > 0 && A[i][j] > 0)
                {
                    A[i][j] = A[i - 1][j] + 1;
                }
            }
        }

        for (int i = 0; i < m; ++i)
        {
            Array.Sort(A[i]);
            res = Math.Max(res, A[i][0] * A[0].Length);
            for (int j = 1; j < n; ++j)
            {
                if (A[i][j - 1] != A[i][j])
                    res = Math.Max(res, A[i][j] * (A[0].Length - j));
            }
        }
        return res;
    }
}
