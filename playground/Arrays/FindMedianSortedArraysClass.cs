namespace playground.Arrays;

public class FindMedianSortedArraysClass
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays
    /// </summary>
    public static double FindMedianSortedArrays(int[] A, int[] B)
    {
        if (A.Length > B.Length)
        {
            (B, A) = (A, B);
        }
        int m = A.Length, n = B.Length;
        int total = m + n, half = total / 2;
        int l = 0, r = m - 1;
        double res = 0;
        while (true)
        {
            int i = l > r ? -1 : (l + r) / 2;
            int j = half - i - 2;

            double Aleft = i >= 0 ? A[i] : double.NegativeInfinity;
            double Aright = i + 1 < m ? A[i + 1] : double.PositiveInfinity;
            double Bleft = j >= 0 ? B[j] : double.NegativeInfinity;
            double Bright = j + 1 < n ? B[j + 1] : double.PositiveInfinity;

            if (Aleft <= Bright && Bleft <= Aright)
            {
                res = total % 2 == 0 ?
                    (Math.Max(Aleft, Bleft) + Math.Min(Aright, Bright)) / 2 :
                    Math.Min(Aright, Bright);
                break;
            }
            else if (Aleft > Bright)
            {
                r = i - 1;
            }
            else
            {
                l = i + 1;
            }
        }
        return res;
    }
}
