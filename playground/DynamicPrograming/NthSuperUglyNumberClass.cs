namespace playground.DynamicPrograming;

public class NthSuperUglyNumberClass
{
    ///<remarks>https://leetcode.com/problems/super-ugly-number</remarks>
    public static int NthSuperUglyNumber(int n, int[] primes)
    {
        var res = new long[n];
        res[0] = 1;
        var pq = new PriorityQueue<(int p, int idx), long>();
        for (int i = 0; i < primes.Length; ++i)
        {
            pq.Enqueue((primes[i], 0), primes[i]);
        }
        for (int i = 1; i < n; ++i)
        {
            var (p, idx) = pq.Dequeue();
            res[i] = p * res[idx];
            pq.Enqueue((p, idx + 1), p * res[idx + 1]);

            var peek = pq.Peek();
            while (peek.p * res[peek.idx] == p * res[idx])
            {
                pq.Dequeue();
                pq.Enqueue((peek.p, peek.idx + 1), peek.p * res[peek.idx + 1]);
                peek = pq.Peek();
            }
        }
        return (int)res[n - 1];
    }
}
