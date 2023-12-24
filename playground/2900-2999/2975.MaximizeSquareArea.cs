namespace playground;

public class MaximizeSquareArea2975
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-square-area-by-removing-fences-from-a-field
    /// </summary>
    public static int MaximizeSquareArea(int m, int n, int[] A, int[] B)
    {
        long res = 0, MOD = (long)1e9 + 7;
        A = A.Append(1).Append(m).ToArray();
        B = B.Append(1).Append(n).ToArray();
        HashSet<int> set = new();
        for (int i = 0; i < A.Length; ++i)
        {
            for (int j = i + 1; j < A.Length; ++j)
            {
                set.Add(Math.Abs(A[j] - A[i]));
            }
        }
        for (int i = 0; i < B.Length; i++)
        {
            for (int j = i + 1; j < B.Length; j++)
            {
                var edge = Math.Abs(B[i] - B[j]);
                if (set.Contains(edge))
                {
                    res = Math.Max(res, edge);
                }
            }
        }
        return res == 0 ? -1 : (int)(res * res % MOD);
    }
}
