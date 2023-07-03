namespace playground.Mathematics;

public class CountPrimesClass
{
    /// <summary>
    /// https://leetcode.com/problems/count-primes
    /// </summary>
    public static int CountPrimes(int n)
    {
        int count = 0;
        bool[] isPrime = new bool[n + 1];
        Array.Fill(isPrime, true);

        for (int i = 2; i < n; ++i)
        {
            if (!isPrime[i])
                continue;
            for (int j = i * 2; j <= n; j += i)
                isPrime[j] = false;
            if (isPrime[i])
                count++;
        }
        return count;
    }
}
