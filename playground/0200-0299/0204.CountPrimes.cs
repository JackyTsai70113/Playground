namespace playground;

public class CountPrimes0204
{
    /// <summary>
    /// https://leetcode.com/problems/count-primes
    /// </summary>
    /// 計算質數
    public static int CountPrimes(int n)
    {
        int count = 0;
        bool[] isPrime = new bool[n];
        Array.Fill(isPrime, true);
        for (int p = 2; p < n; ++p)
        {
            if (!isPrime[p]) continue;
            for (int i = p * 2; i < n; i += p)
                isPrime[i] = false;
            count++;
        }
        return count;
    }
}
