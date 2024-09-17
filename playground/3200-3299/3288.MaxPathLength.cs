namespace playground;

public class MaxPathLength3288
{
    public static int MaxPathLength(int[][] A, int k)
    {
        int kx = A[k][0], ky = A[k][1];
        var left = A.Where(a => a[0] < kx && a[1] < ky).ToArray();
        var right = A.Where(a => a[0] > kx && a[1] > ky).ToArray();
        return 1 + LongestIncreasingSubsequence(left) + LongestIncreasingSubsequence(right);
    }

    public static int LongestIncreasingSubsequence(int[][] A)
    {
        Array.Sort(A, (x, y) => x[0] != y[0] ? x[0] - y[0] : y[1] - x[1]);
        var dp = new List<int>();
        foreach (var a in A)
        {
            int l = 0, r = dp.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (dp[m] >= a[1])
                    r = m;
                else
                    l = m + 1;
            }
            if (l == dp.Count)
                dp.Add(a[1]);
            else
                dp[l] = a[1];
        }
        return dp.Count;
    }
}
