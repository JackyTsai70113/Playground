namespace playground._3400_3499;

public class _3413_MaximumCoins
{
    public static long MaximumCoins(int[][] A, int k)
    {
        Array.Sort(A, (x, y) => x[0] - y[0]);
        int n = A.Length;

        // start at A[i][0]
        long res = 0, cur = 0;
        for (int l = 0, r = 0; l < n; l++)
        {
            while (r < n && A[r][1] <= A[l][0] + k - 1)
            {
                cur += (long)A[r][2] * (A[r][1] - A[r][0] + 1);
                r++;
            }
            if (r < n)
            {
                long part = (long)A[r][2] * Math.Max(0, A[l][0] + k - 1 - A[r][0] + 1);
                res = Math.Max(res, cur + part);
            }
            cur -= (long)A[l][2] * (A[l][1] - A[l][0] + 1);
        }

        // end at A[i][1]
        cur = 0;
        for (int l = 0, r = 0; r < n; r++)
        {
            cur += (long)A[r][2] * (A[r][1] - A[r][0] + 1);
            while (A[l][1] < A[r][1] - k + 1)
            {
                cur -= (long)A[l][2] * (A[l][1] - A[l][0] + 1);
                l++;
            }
            long part = (long)A[l][2] * Math.Max(0, A[r][1] - k - A[l][0] + 1);
            res = Math.Max(res, cur - part);
        }

        return res;
    }
}
