namespace playground.LeetCode._3000_3999;

public class _3578_CountPartitions
{
    public static int CountPartitions(int[] A, int k)
    {
        long MOD = 1_000_000_007;
        int n = A.Length;
        var dp = new long[n + 1];
        dp[0] = 1;

        int l = 0, r = 0;
        var presumDp = new long[n + 2];
        presumDp[0] = 0;
        presumDp[1] = dp[0];

        var minDq = new LinkedList<int>();
        var maxDq = new LinkedList<int>();

        for (int i = 1; i <= n; i++)
        {
            r = i - 1;
            while (minDq.Count > 0 && A[minDq.Last.Value] >= A[r])
            {
                minDq.RemoveLast();
            }
            minDq.AddLast(r);


            while (maxDq.Count > 0 && A[maxDq.Last.Value] <= A[r])
            {
                maxDq.RemoveLast();
            }
            maxDq.AddLast(r);

            while (A[maxDq.First.Value] - A[minDq.First.Value] > k)
            {
                if (maxDq.First.Value == l) maxDq.RemoveFirst();
                if (minDq.First.Value == l) minDq.RemoveFirst();
                l++;
            }

            dp[i] = (presumDp[i] + MOD - presumDp[l]) % MOD;
            presumDp[i + 1] = (presumDp[i] + dp[i]) % MOD;
        }
        return (int)dp[n];
    }
}
