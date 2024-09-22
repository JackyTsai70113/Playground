namespace playground._1800_1899;

public class _1838_MaxFrequency
{
    public static int MaxFrequency(int[] A, int k)
    {
        bool Valid(int l, int r, long sum)
        {
            return ((long)r - l + 1) * A[r] - sum <= k;
        }
        Array.Sort(A);
        int n = A.Length, l = 0, max = 1;
        long sum = 0;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            sum += A[r];
            while (!Valid(l, r, sum))
            {
                // update state by A[l]
                sum -= A[l];
                l++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
