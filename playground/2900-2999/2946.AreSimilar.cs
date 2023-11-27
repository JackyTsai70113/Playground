namespace playground;

public class AreSimilar_2946
{
    /// <summary>
    /// https://leetcode.com/problems/matrix-similarity-after-cyclic-shifts
    /// </summary>
    public static bool AreSimilar(int[][] A, int k)
    {
        int m = A.Length, n = A[0].Length;
        k %= n;
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if (j % 2 == 1 && A[i][j] != A[i][(j + k) % n])
                    return false;
                if (j % 2 == 0 && A[i][j] != A[i][(j + n - k) % n])
                    return false;
            }
        }
        return true;
    }
}
