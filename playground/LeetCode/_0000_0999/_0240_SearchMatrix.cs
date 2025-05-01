namespace playground.LeetCode._0000_0999;

public class _0240_SearchMatrix
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix
    /// </summary>
    public static bool SearchMatrix(int[][] A, int target)
    {
        int r = 0, c = A[0].Length - 1;
        while (r < A.Length && c >= 0)
        {
            if (A[r][c] == target)
                return true;
            else if (A[r][c] > target)
                c--;
            else
                r++;
        }
        return false;
    }

    public static bool SearchMatrix2(int[][] A, int target)
    {
        int m = A.Length, n = A[0].Length;
        return Search(A, target, 0, m - 1, 0, n - 1);
    }

    static bool Search(int[][] A, int target, int r0, int r1, int c0, int c1)
    {
        if (r0 == r1 && c0 == c1)
            return A[r0][c0] == target;
        if (r0 > r1 || c0 > c1)
            return false;
        int rm = r0 + (r1 - r0) / 2;
        int cm = c0 + (c1 - c0) / 2;
        if (target == A[rm][cm])
            return true;
        if (target < A[rm][cm])
        {
            return Search(A, target, r0, rm, c0, cm) ||
                Search(A, target, rm + 1, r1, c0, cm) ||
                Search(A, target, r0, rm, cm + 1, c1);
        }
        else
        {
            return Search(A, target, rm + 1, r1, c0, cm) ||
                Search(A, target, r0, rm, cm + 1, c1) ||
                Search(A, target, rm + 1, r1, cm + 1, c1);
        }
    }
}
