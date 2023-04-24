namespace playground.BinarySearch;

public class SearchMatrixClass
{
    public static bool SearchMatrix(int[][] A, int target)
    {
        int m = A.Length, n = A[0].Length;
        int r0 = 0, r1 = m - 1, c0 = 0, c1 = n - 1;
        while (r0 <= r1 && c0 <= c1)
        {
            int rm = r0 + (r1 - r0) / 2;
            int cm = c0 + (c1 - c0) / 2;
            if (A[rm][cm] == target)
            {
                return true;
            }
            else if (A[rm][cm] < target)
            {
                if (A[rm][n - 1] < target)
                {
                    r0 = rm + 1;
                }
                else
                {
                    c0 = cm + 1;
                }
            }
            else
            {
                if (A[rm][0] > target)
                {
                    r1 = rm - 1;
                }
                else
                {
                    c1 = cm - 1;
                }
            }
        }
        return false;
    }
}
