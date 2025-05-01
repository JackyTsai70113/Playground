namespace playground.LeetCode._0000_0999;

public class _0120_MinimumTotal
{
    /// <summary>
    /// https://leetcode.com/problems/triangle
    /// </summary>
    public static int MinimumTotal(IList<IList<int>> A)
    {
        int m = A.Count;
        int[] memo = new int[m], memo2;
        Array.Fill(memo, int.MaxValue);
        memo[0] = A[0][0];
        for (int i = 1; i < A.Count; i++)
        {
            memo2 = new int[m];
            Array.Fill(memo2, int.MaxValue);
            for (int j = 0; j <= i; j++)
            {
                if (j - 1 >= 0)
                    memo2[j] = Math.Min(memo2[j], memo[j - 1] + A[i][j]);
                if (j < i)
                    memo2[j] = Math.Min(memo2[j], memo[j] + A[i][j]);
            }
            memo = memo2;
        }
        return memo.Min();
    }
}
