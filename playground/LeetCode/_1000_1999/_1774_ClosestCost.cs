namespace playground.LeetCode._1000_1999;

public class _1774_ClosestCost
{
    public static int ClosestCost(int[] baseCosts, int[] toppingCosts, int target)
    {
        var baseMax = baseCosts.Max();
        int max = baseMax, min = baseMax;
        if (baseMax < target)
        {
            max = baseMax + (target - baseMax) * 2;
        }
        else
        {
            min = Math.Max(0, target - (baseMax - target));
        }

        var dp = new bool[max + 1];
        foreach (var b in baseCosts)
        {
            dp[b] = true;
        }

        foreach (var t in toppingCosts)
        {
            for (int i = max; i >= 0; i--)
            {
                if (i >= t && dp[i - t])
                    dp[i] = true;
                if (i >= t * 2 && dp[i - t * 2])
                    dp[i] = true;
            }
        }

        var res = baseMax;
        for (int i = max; i >= min; i--)
        {
            if (dp[i] && Math.Abs(i - target) <= Math.Abs(res - target))
                res = i;
        }
        return res;
    }
}
