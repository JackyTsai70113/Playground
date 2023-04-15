namespace playground.DynamicPrograming;

public class MiceAndCheeseClass
{
    public static int MiceAndCheese(int[] reward1, int[] reward2, int k)
    {
        int n = reward1.Length;
        var dp = new int[n + 1];
        var res = 0;
        for (int i = 0; i < n; ++i)
        {
            var temp = new int[n + 1];
            for (int j = 0; j < n + 1; ++j)
            {
                temp[j] = dp[j];
            }
            for (int j = Math.Max(0, k - n + i); j <= i && j <= k; ++j)
            {
                dp[j] = Math.Max(dp[j], (i - 1 >= 0 ? temp[j] : 0) + reward2[i]);
                dp[j + 1] = Math.Max(dp[j + 1], (i - 1 >= 0 ? temp[j] : 0) + reward1[i]);
                //Console.WriteLine(j + " " + dp[i,j] + " " + dp[i,j+1]);
                if (j == k)
                {
                    res = Math.Max(res, dp[j]);
                }
                if (j + 1 == k)
                {
                    res = Math.Max(res, dp[j + 1]);
                }
            }
        }
        return res;
    }
}