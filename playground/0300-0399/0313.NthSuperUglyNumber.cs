namespace playground;

public class NthSuperUglyNumber0313
{
    /// <summary>
    /// https://leetcode.com/problems/super-ugly-number
    /// </summary>
    /// <remarks>
    /// O(nlogk)/O(max(n,k))
    /// </remarks>
    public static int NthSuperUglyNumber(int n, int[] primes)
    {
        var res = new long[n];
        var pq = new PriorityQueue<(int p, int idx), long>();
        for (int i = 0; i < primes.Length; i++)
        {
            pq.Enqueue((primes[i], 0), primes[i]);
        }
        res[0] = 1;
        for (int i = 1; i < n; i++)
        {
            var (p, idx) = pq.Peek();
            res[i] = p * res[idx];
            while (res[i] == pq.Peek().p * res[pq.Peek().idx])
            {
                (p, idx) = pq.Dequeue();
                pq.Enqueue((p, idx + 1), p * res[idx + 1]);
            }
        }
        return (int)res[n - 1];
    }

    /// <remarks>
    /// O(nk)/O(max(n,k))
    /// </remarks>
    public static int NthSuperUglyNumber2(int n, int[] primes)
    {
        long[] res = new long[n], vals = new long[primes.Length];
        res[0] = 1;
        var indexes = new int[primes.Length];
        Array.Fill(vals, 1);
        for (int i = 1; i < n; i++)
        {
            res[i] = long.MaxValue;
            for (int j = 0; j < primes.Length; j++)
            {
                if (res[i - 1] == vals[j])
                    vals[j] = res[indexes[j]++] * primes[j];
                res[i] = Math.Min(res[i], vals[j]);
            }
        }
        return (int)res[n - 1];
    }
}
