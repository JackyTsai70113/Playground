namespace playground;

public class _3233_NonSpecialCount
{
    public static int NonSpecialCount(int l, int r)
    {
        int n = (int)Math.Sqrt(r);
        bool[] primes = Primes(n + 1);
        primes[1] = false;
        int count = 0;
        for (long i = 1; i <= n; i++)
        {
            if (primes[i] && i * i >= l && i * i <= r)
                count++;
        }
        return r - l + 1 - count;
    }

    static bool[] Primes(int n)
    {
        bool[] isPrime = new bool[n];
        Array.Fill(isPrime, true);
        for (int p = 2; p < n; ++p)
        {
            if (!isPrime[p]) continue;
            for (int i = p * 2; i < n; i += p)
                isPrime[i] = false;
        }
        return isPrime;
    }
}
