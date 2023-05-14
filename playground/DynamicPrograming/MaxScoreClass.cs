namespace playground.DynamicPrograming;

public class MaxScoreClass
{
    public static int MaxScore(int[] nums)
    {
        int n = nums.Length;

        int gcd(int x, int y)
        {
            if (y == 0) return x;
            return gcd(y, x % y);
        }

        var dp = new int[1 << 14];
        for (int i = 0; i < dp.Length; ++i)
        {
            dp[i] = -1;
        }
        
        int dfs(int op, int mask)
        {
            if(op>n/2) return 0;
            if(dp[mask] != -1) return dp[mask];
            for (int i = 0; i < n; ++i){
                if((mask & (1<<i)) > 0)
                    continue;
                for (int j = i+1; j < n; j++)
                {
                    if((mask & (1<<j)) > 0)
                        continue;
                    int newMask = mask | (1 << i) | (1 << j);
                    int score = op * gcd(nums[i], nums[j]) + dfs(op + 1, newMask);
                    dp[mask] = Math.Max(dp[mask], score);
                }
            }
            return dp[mask];
        }
        return dfs(1, 0);
    }
}
