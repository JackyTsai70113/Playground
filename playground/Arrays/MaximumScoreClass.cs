namespace playground.Arrays;

public class MaximumScoreClass
{
    public static int MaximumScore(int[] A, int k) {
        int res = A[k], mini = A[k], i = k, j = k, n = A.Length;
        while (i > 0 || j < n - 1) {
            if (i == 0)
                ++j;
            else if (j == n - 1)
                --i;
            else if (A[i - 1] < A[j + 1])
                ++j;
            else
                --i;
            mini = Math.Min(mini, Math.Min(A[i], A[j]));
            res = Math.Max(res, mini * (j - i + 1));
        }
        return res;
    }
}
