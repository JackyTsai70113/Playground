namespace playground.LeetCode._1000_1999;

public class _1871_CanReach
{
    public static bool CanReach(string s, int minJump, int maxJump)
    {
        if (s[^1] == '1')
            return false;

        int n = s.Length, pre = 0;
        var dp = new bool[n];
        dp[0] = true;
        for (int i = 1; i < n; i++)
        {
            if (i >= minJump && dp[i - minJump])
                pre++;
            if (i > maxJump && dp[i - maxJump - 1])
                pre--;
            dp[i] = pre > 0 && s[i] == '0';
        }
        return dp[^1];
    }
}
