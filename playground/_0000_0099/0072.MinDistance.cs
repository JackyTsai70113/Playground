namespace playground;

public class MinDistance0072
{
    /// <summary>
    /// https://leetcode.com/problems/edit-distance
    /// </summary>
    public static int MinDistance(string A, string B)
    {
        int n1 = A.Length, n2 = B.Length;
        var memo = new int[n1 + 1, n2 + 1];
        for (int i = 0; i <= n1; i++)
            memo[i, 0] = i;
        for (int i = 0; i <= n2; i++)
            memo[0, i] = i;
        for (int i = 1; i <= n1; i++)
        {
            for (int j = 1; j <= n2; j++)
            {
                if (A[i - 1] == B[j - 1])
                {
                    memo[i, j] = memo[i - 1, j - 1];
                }
                else
                {
                    memo[i, j] = Math.Min(memo[i - 1, j - 1], Math.Min(memo[i - 1, j], memo[i, j - 1])) + 1;
                }
            }
        }
        return memo[n1, n2];
    }
}
