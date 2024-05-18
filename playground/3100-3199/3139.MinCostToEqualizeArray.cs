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
        int n = A.Length, max = A[0], min = A[0], MOD = (int)1e9 + 7;
        long total = 0;
        foreach (var num in A)
        {
            max = Math.Max(max, num);
            min = Math.Min(min, num);
            total += num;
        }
        total = (long)max * n - total;
        // case 1
        if (c1 * 2 <= c2 || n <= 2)
            return (int)(total * c1 % MOD);

        // case 2
        long op1 = Math.Max(0, ((long)max - min) * 2 - total);
        long op2 = total - op1;
        long res = (op1 + op2 % 2) * c1 + op2 / 2 * c2;

        // case 3: increase max to max+1, means that op1 save n-2 times, op2 more n-1 times
        total += op1 / (n - 2) * n;
        op1 %= n - 2;
        op2 = total - op1;
        res = Math.Min(res, (op1 + op2 % 2) * c1 + op2 / 2 * c2);

        // case 4: use 0 or 1 op1
        for (int i = 0; i < 2; i++)
        {
            total += n;
            res = Math.Min(res, total % 2 * c1 + total / 2 * c2);
        }

        return (int)(res % MOD);
    }
}
