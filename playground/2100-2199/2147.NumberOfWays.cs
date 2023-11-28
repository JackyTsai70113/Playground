namespace playground;

public class NumberOfWays_2147
{
    public static int NumberOfWays(string s)
    {
        int n = s.Length, cur = 1;
        long res = 1, MOD = (long)1e9 + 7;
        var pres = new int[n + 1];
        for (int i = 1; i <= n; ++i)
            pres[i] = pres[i - 1] + (s[i - 1] == 'S' ? 1 : 0);
        if (pres[n] == 0 || pres[n] % 2 == 1) return 0;
        for (int i = 2; i <= n; ++i)
        {
            if (pres[i] > 0 && pres[i] % 2 == 0)
            {
                if (pres[i - 1] != pres[i])
                {
                    res = res * cur % MOD;
                    cur = 1;
                }
                else
                {
                    cur++;
                }
            }
        }
        return (int)res;
    }
}
