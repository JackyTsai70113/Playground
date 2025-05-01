namespace playground;

public class _3142_SatisfiesConditions
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-grid-satisfies-conditions
    /// </summary>
    public static bool SatisfiesConditions(int[][] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A[0].Length; j++)
            {
                if (j + 1 < A[0].Length && A[i][j] == A[i][j + 1])
                    return false;
                if (i + 1 < A.Length && A[i][j] != A[i + 1][j])
                    return false;
            }
        }
        return true;
    }
}
