namespace playground.DynamicPrograming;

public class DistributeCookiesClass
{
    /// <summary>
    /// https://leetcode.com/problems/fair-distribution-of-cookies
    /// </summary>
    public static int DistributeCookies(int[] A, int k)
    {
        int n = A.Length, res = int.MaxValue;
        var distribution = new int[k];
        void dfs(int cur)
        {
            if (cur == n)
            {
                res = Math.Min(res, distribution.Max());
                return;
            }
            for (int i = 0; i < k; ++i)
            {
                if (k - 1 - i > n - 1 - cur)
                    continue;
                distribution[i] += A[cur];
                dfs(cur + 1);
                distribution[i] -= A[cur];
            }
        }
        dfs(0);
        return res;
    }
}
