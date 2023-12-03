namespace playground;

public class NumberOfSequence_2954
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-infection-sequences
    /// </summary>
    public int NumberOfSequence(int n, int[] sick)
    {
        long MOD = (long)(1e9) + 7;
        var (fact, inv) = GetFactorials(n, MOD);
        long res = 1;
        for (int i = 1; i < sick.Length; ++i)
        {
            int group = sick[i] - sick[i - 1] - 1;
            res = res * PowMod(2, group - 1, MOD) % MOD;
            res = res * CombinationNumber(fact, inv, sick[i] - i, group, MOD) % MOD;
        }
        return (int)(res * CombinationNumber(fact, inv, n - sick.Length, n - sick[^1] - 1, MOD) % MOD);
    }

    public long CombinationNumber(long[] fact, long[] inv, int n, int k, long mod)
    {
        if (n == k || k == 0) return 1;
        long res = fact[n] % mod * inv[k] % mod * inv[n - k] % mod;
        return res;
    }

    private long PowMod(long x, int y, long mod)
    {
        long res = 1;
        while (y > 0)
        {
            if ((y & 1) > 0) res = res * x % mod;
            x = x * x % mod;
            y /= 2;
        }
        return res;
    }

    public (long[] factorials, long[] invFactorials) GetFactorials(int n, long mod)
    {
        var inv = new long[n + 1];
        var factorials = new long[n + 1];
        var invFactorials = new long[n + 1];
        inv[1] = factorials[1] = invFactorials[1] = 1;
        for (int i = 2; i <= n; ++i)
        {
            factorials[i] = factorials[i - 1] * i % mod;
            inv[i] = mod - mod / i * inv[mod % i] % mod;
            invFactorials[i] = invFactorials[i - 1] * inv[i] % mod;
        }
        return (factorials, invFactorials);
    }
}
