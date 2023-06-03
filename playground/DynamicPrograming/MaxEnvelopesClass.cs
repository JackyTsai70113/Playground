namespace playground.DynamicPrograming;

public class MaxEnvelopesClass
{
    /// <summary>
    /// https://leetcode.com/problems/russian-doll-envelopes
    /// </summary>
    public static int MaxEnvelopes(int[][] es)
    {
        int n = es.Length, res = 0;
        Array.Sort(es, (x, y) =>
        {
            if (x[0] != y[0])
                return x[0] - y[0];
            return y[1] - x[1];
        });
        var dp = new int[n];
        for (int i = 0; i < n; ++i)
        {
            var biggerCount = Array.BinarySearch(dp, 0, res, es[i][1]);
            if (biggerCount < 0)
            {
                biggerCount = ~biggerCount;
            }
            dp[biggerCount] = es[i][1];
            if (biggerCount == res)
            {
                res++;
            }
        }
        return res;
    }
}
