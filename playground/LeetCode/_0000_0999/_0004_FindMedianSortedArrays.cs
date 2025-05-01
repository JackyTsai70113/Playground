namespace playground.LeetCode._0000_0999;

public class _0004_FindMedianSortedArrays
{
    public static double FindMedianSortedArrays(int[] A, int[] B)
    {
        if (A.Length > B.Length)
            (B, A) = (A, B);
        int m = A.Length, n = B.Length;
        int total = m + n, half = total / 2;
        int l = 0, r = m - 1;
        double res;
        while (true)
        {
            int i = l > r ? -1 : (l + r) / 2;
            int j = half - i - 2;
            double aLeft = i >= 0 ? A[i] : double.MinValue;
            double aRight = i + 1 < m ? A[i + 1] : double.MaxValue;
            double bLeft = j >= 0 ? B[j] : double.MinValue;
            double bRight = j + 1 < n ? B[j + 1] : double.MaxValue;
            if (aLeft <= bRight && bLeft <= aRight)
            {
                res = total % 2 == 0 ?
                    (Math.Max(aLeft, bLeft) + Math.Min(aRight, bRight)) / 2 :
                    Math.Min(aRight, bRight);
                break;
            }
            else if (aLeft > bRight)
                r = i - 1;
            else
                l = i + 1;
        }
        return res;
    }
}
