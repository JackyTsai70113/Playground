namespace playground;

public class _3130_NumberOfStableArrays
{
    public static int NumberOfStableArrays(int zero, int one, int limit)
    {
        long[,] dp0 = new long[1001, 1001], dp1 = new long[1001, 1001];
        long[,] presum0 = new long[1001, 1001], presum1 = new long[1001, 1001];
        dp0[0, 0] = dp1[0, 0] = 1;
        presum0[0, 0] = presum1[0, 0] = 1;
        long MOD = (long)1e9 + 7;
        for (int i = 0; i <= zero; i++)
        {
            for (int j = 0; j <= one; j++)
            {
                if (i == 0 && j == 0) continue;

                // k: [1, min(i, limit)]
                dp0[i, j] =
                    (i < 1 ? 0 : presum1[j, i - 1]) -
                    (i - Math.Min(i, limit) - 1 < 0 ? 0 : presum1[j, i - Math.Min(i, limit) - 1]);
                dp1[i, j] =
                    (j < 1 ? 0 : presum0[i, j - 1]) -
                    (j - Math.Min(j, limit) - 1 < 0 ? 0 : presum0[i, j - Math.Min(j, limit) - 1]);
                dp0[i, j] = (MOD + dp0[i, j]) % MOD;
                dp1[i, j] = (MOD + dp1[i, j]) % MOD;

                presum0[i, j] = dp0[i, j] + (j < 1 ? 0 : presum0[i, j - 1]);
                presum1[j, i] = dp1[i, j] + (i < 1 ? 0 : presum1[j, i - 1]);
                presum0[i, j] %= MOD;
                presum1[j, i] %= MOD;
            }
        }
        var res = (dp0[zero, one] + dp1[zero, one]) % MOD;
        return (int)res;
    }

    /*
    dp0[i][j]: the total number of stable binary arrays with i zeros, j ones and ending with 0
    dp1[i][j]: the total number of stable binary arrays with i zeros, j ones and ending with 1

    X X X X X X X X 0
            _ _ _ _ _
    dp0[i][j] = sum(dp1[i-limit][j], dp1[i-limit+1][j]... dp1[i-1][j])
    dp1[i][j] = sum(dp0[i][j-limit], dp0[i][j-limit+1]... dp0[i][j-1])
    */
}
