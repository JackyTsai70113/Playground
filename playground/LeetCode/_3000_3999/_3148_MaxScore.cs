namespace playground;

public class _3148_MaxScore
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-difference-score-in-a-grid
    /// </summary>
    public static int MaxScore(IList<IList<int>> A)
    {
        int m = A.Count, n = A[0].Count;
        var memo = new int[n];
        int res = -1000000;
        for (int i = m - 1; i >= 0; i--)
        {
            var memo2 = new int[n];
            for (int j = n - 1; j >= 0; j--)
            {
                int a = i + 1 == m ? -1000000 : (Math.Max(0, memo[j])) + A[i + 1][j] - A[i][j];
                int b = j + 1 == n ? -1000000 : (Math.Max(0, memo2[j + 1])) + A[i][j + 1] - A[i][j];
                memo2[j] = Math.Max(a, b);
                res = Math.Max(res, memo2[j]);
            }
            memo = memo2;
        }
        return res;
    }
}
