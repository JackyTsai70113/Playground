namespace playground.LeetCode._0000_0999;

public class _0354_MaxEnvelopes
{
    /// <summary>
    /// https://leetcode.com/problems/russian-doll-envelopes
    /// </summary>
    public static int MaxEnvelopes(int[][] A)
    {
        Array.Sort(A, (x, y) =>
        {
            if (x[0] == y[0])
                return y[1] - x[1];
            return x[0] - y[0];
        });
        var dp = new List<int>();
        for (int i = 0; i < A.Length; i++)
        {
            int l = 0, r = dp.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (dp[m] >= A[i][1]) // 取 >= A[i][1] 的極左值
                    r = m;
                else
                    l = m + 1;
            }
            if (l == dp.Count)
                dp.Add(A[i][1]);
            else
                dp[l] = A[i][1];
        }
        return dp.Count;
    }
}
