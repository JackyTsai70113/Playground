namespace playground.LeetCode._1000_1999;

public class _1143_LongestCommonSubsequence
{
    public static int LongestCommonSubsequence(string text1, string text2)
    {
        if (text1.Length < text2.Length)
            (text1, text2) = (text2, text1);
        int n1 = text1.Length, n2 = text2.Length;
        var dp = new int[n2 + 1];
        var dp2 = new int[n2 + 1];
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                if (text1[i] == text2[j])
                {
                    dp2[j + 1] = 1 + dp[j];
                }
                else
                {
                    dp2[j + 1] = Math.Max(dp2[j], dp[j + 1]);
                }
            }
            (dp, dp2) = (dp2, dp);
        }
        return dp[n2];
    }
}
