namespace playground._3400_3499;

public class _3489_MinZeroArray
{
    public static int MinZeroArray(int[] nums, int[][] queries)
    {
        if (nums.All(x => x == 0))
            return 0;
        int n = nums.Length;
        var dp = new bool[nums.Max() + 1];
        int max = -1;
        for (int i = 0; i < n; i++)
        {
            Array.Clear(dp);
            dp[0] = true;
            for (int j = 0; j < queries.Length; j++)
            {
                if (i < queries[j][0] || i > queries[j][1])
                    continue;
                for (int k = dp.Length - 1; k >= 0; k--)
                {
                    if (dp[k] && k + queries[j][2] < dp.Length)
                    {
                        dp[k + queries[j][2]] = true;
                    }
                }
                if (dp[nums[i]])
                {
                    max = Math.Max(max, j);
                    break;
                }
            }
            if (!dp[nums[i]])
                return -1;
        }
        return max + 1;
    }
}
