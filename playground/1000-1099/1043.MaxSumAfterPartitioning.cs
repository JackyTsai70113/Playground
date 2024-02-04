namespace playground;

public class MaxSumAfterPartitioning1043
{
    /// <summary>
    /// https://leetcode.com/problems/partition-array-for-maximum-sum
    /// /// </summary>
    public static int MaxSumAfterPartitioning(int[] A, int k)
    {
        int n = A.Length, max;
        var memo = new int[n];
        for (int i = 0; i < n; i++)
        {
            max = int.MinValue;
            for (int j = 0; j < k && i + j < n; j++)
            {
                max = Math.Max(max, A[i + j]);
                if (i + j < k)
                    memo[i + j] = Math.Max(memo[i + j], (i + j + 1) * max);
                else
                    memo[i + j] = Math.Max(memo[i + j], (j + 1) * max + memo[i - 1]);
            }
        }
        return memo[n - 1];
    }
}
/*
start\num 01, 15, 07, 09
    0     01, 30, 45
    1         16, 31, 46
    2             37, 48
    3                 54
*/