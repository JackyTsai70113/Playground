namespace playground.DynamicPrograming;

public class CountRoutesClass
{
    public static int CountRoutes(int[] locations, int start, int finish, int fuel)
    {
        int n = locations.Length, MOD = (int)(1e9 + 7);
        var memo = new int[n + 1, fuel + 1];
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= fuel; j++)
            {
                memo[i, j] = -1;
            }
        }
        int helper(int cur, int fuel)
        {
            if (fuel < 0)
                return 0;
            if (memo[cur,fuel] != -1)
                return memo[cur, fuel];
            memo[cur, fuel] = 0;
            if(cur == finish)
                memo[cur, fuel] = 1;
            for (int i = 0; i < n; ++i)
            {
                if (i == cur)
                    continue;
                memo[cur, fuel] = (memo[cur, fuel] + helper(i, fuel - Math.Abs(locations[i] - locations[cur]))) % MOD;
            }
            return memo[cur, fuel];
        }
        return helper(start, fuel);
    }
}
