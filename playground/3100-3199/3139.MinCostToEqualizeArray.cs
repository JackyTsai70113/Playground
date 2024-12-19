using System.Collections.Generic;

namespace playground;

public class MinCostToEqualizeArray3139
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-to-equalize-array
    /// </summary>
    /// <remarks>
    /// 1. cost1 * 2 &gt; cost2 or len &lt;= 2: use cost1 to achieve max <br/>
    /// 2. cost1 * 2 &lt; cost2: use cost2 to achieve max <br/>
    /// 3. cost1 * 2 &lt;&lt; cost2: use cost2 to achieve increased max <br/>
    /// 4. cost1 * 2 &lt;&lt;&lt;&lt; cost2: only use cost2 to achieve increased max <br/>
    /// </remarks>
    public static int MinCostToEqualizeArray(int[] A, int c1, int c2)
    {
        int n = A.Length, max = A[0], min = A[0];
        long sum = 0, MOD = (long)1e9 + 7;
        foreach (var a in A)
        {
            max = Math.Max(max, a);
            min = Math.Min(min, a);
            sum += a;
        }
        if (n == 2 || c1 * 2 < c2)
            return (int)(((long)max * n - sum) * c1 % MOD);
        c2 = Math.Min(2 * c1, c2);

        long total = (long)max * n - sum;
        long count1 = Math.Max(0, (max - min) * 2 - total);
        count1 += (total - count1) % 2;
        long count2 = (total - count1) / 2;
        long res = count1 * c1 + count2 * c2;

        long GetCost(long newMax)
        {
            long total = newMax * n - sum;
            long count1 = Math.Max(0, (newMax - min) * 2 - total);
            count1 += (total - count1) % 2;
            long count2 = (total - count1) / 2;
            return count1 * c1 + count2 * c2;
        }

        int cur = max;
        while (GetCost(cur + 2) < GetCost(cur))
        {
            cur += 2;
        }
        res = Math.Min(res, GetCost(cur));

        cur = max + 1;
        while (GetCost(cur + 2) < GetCost(cur))
        {
            cur += 2;
        }
        res = Math.Min(res, GetCost(cur));

        return (int)(res % MOD);
    }
}
