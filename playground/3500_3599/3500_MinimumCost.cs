namespace playground._3500_3599;

public class _3500_MinimumCost
{
    public static long MinimumCost(int[] nums, int[] cost, int k)
    {
        int n = nums.Length;
        long[] presum = new long[n + 1], precost = new long[n + 1];
        presum[0] = nums[0];
        precost[0] = cost[0];
        for (int i = 1; i < n; i++)
        {
            presum[i] = presum[i - 1] + nums[i];
            precost[i] = precost[i - 1] + cost[i];
        }

        var dp = new long[n, n];

        long solve(int l, int r)
        {
            if (r == n)
            {
                if (l == n) return 0;
                return long.MaxValue;
            }
            if (dp[l, r] != 0) return dp[l, r];
            long curNumSum = presum[r];
            long curCostSum = precost[n - 1];
            if (l != 0)
            {
                curNumSum = presum[r] - presum[l - 1];
                curCostSum = precost[n - 1] - precost[l - 1];
            }
            long endHere = (curNumSum + k) * curCostSum + solve(r + 1, r + 1);
            long extend = solve(l, r + 1);
            return dp[l, r] = Math.Min(endHere, extend);
        }
        return solve(0, 0);
    }
}
