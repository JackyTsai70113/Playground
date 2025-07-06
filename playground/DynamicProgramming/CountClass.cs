namespace playground.DynamicProgramming;

public class CountClass
{
    readonly int MOD = (int)1e9 + 7;
    /// <summary>
    /// https://leetcode.com/problems/count-of-integers
    /// </summary>
    public int Count(string num1, string num2, int min_sum, int max_sum)
    {
        int a = Count(num1, min_sum, max_sum);
        int b = Count(num2, min_sum, max_sum);
        var res = (MOD + b - a) % MOD;
        int sum = 0;
        for (var i = 0; i < num2.Length; i++)
        {
            sum += num2[i] - '0';
        }
        if (min_sum <= sum && sum <= max_sum)
            res = (res + 1) % MOD;
        return res;
    }

    private int Count(string num, int minSum, int maxSum)
    {
        int sum = 0;
        var dp = new int[num.Length, maxSum + 1];
        for (int i = 0; i < num.Length; ++i)
        {
            for (int j = 0; j < num[i] - '0' && sum + j <= maxSum; ++j)
            {
                dp[i, sum + j] = 1;
            }
            sum += num[i] - '0';
        }

        for (var i = 0; i < num.Length - 1; i++)
        {
            for (int j = 0; j <= maxSum && dp[i, j] > 0; ++j)
            {
                for (int k = 0; k <= 9 && j + k <= maxSum; ++k)
                {
                    dp[i + 1, j + k] = (dp[i + 1, j + k] + dp[i, j]) % MOD;
                }
            }
        }

        var res = 0;
        for (int i = minSum; i <= maxSum; ++i)
        {
            res = (res + dp[num.Length - 1, i]) % MOD;
        }
        return res;
    }
}