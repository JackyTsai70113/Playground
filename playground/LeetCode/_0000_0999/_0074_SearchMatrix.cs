namespace playground.LeetCode._0000_0999;

public class _0074_SearchMatrix
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix
    /// </summary>
    public static bool SearchMatrix(int[][] A, int target)
    {
        int m = A.Length, n = A[0].Length;
        int l = 0, r = m * n - 1;
        int mid = 0, x = 0, y = 0;
        while (l <= r)
        {
            mid = l + (r - l) / 2;
            (x, y) = (mid / n, mid % n);
            if (A[x][y] == target)
                return true;
            if (A[x][y] > target)
                r = mid - 1;
            else
                l = mid + 1;
        }
        return false;
    }
}
