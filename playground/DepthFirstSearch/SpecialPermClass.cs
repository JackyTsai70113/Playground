namespace playground.DepthFirstSearch;

public class SpecialPermClass
{
    public static int SpecialPerm(int[] nums)
    {
        int n = nums.Length, MOD = (int)(1e9 + 7), res = 0;
        var memo = new int[n, 1 << n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < (1 << n); j++)
                memo[i, j] = -1;
        int dp(int i, int mask)
        {
            if (mask == (1 << n) - 1)
                return 1;
            if (memo[i, mask] != -1)
                return memo[i, mask];
            var res = 0;
            for (int j = 0; j < n; ++j)
            {
                if ((mask & (1 << j)) == 0 && (nums[i] % nums[j] == 0 || nums[j] % nums[i] == 0))
                    res = (res + dp(j, mask | 1 << j)) % MOD;
            }
            return memo[i, mask] = res;
        }

        for (int i = 0; i < n; ++i)
            res = (res + dp(i, 1 << i)) % MOD;
        return res;
    }
}
