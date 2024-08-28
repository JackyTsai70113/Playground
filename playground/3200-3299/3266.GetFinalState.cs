namespace playground;

public class GetFinalState3266
{
    public static int[] GetFinalState(int[] nums, int k, int mul)
    {
        if (mul == 1) return nums;
        int n = nums.Length, max = nums.Max(), MOD = (int)1e9 + 7;
        var pq = new PriorityQueue<int, int>(
            Comparer<int>.Create((i1, i2) =>
                nums[i1] == nums[i2] ?
                i1 - i2 :
                nums[i1] - nums[i2]));
        for (int i = 0; i < n; i++) pq.Enqueue(i, i);

        while (k > 0 && max / nums[pq.Peek()] >= mul)
        {
            var i = pq.Dequeue();
            nums[i] = nums[i] * mul;
            pq.Enqueue(i, i);
            k--;
        }
        int multiple = k / n, remain = k % n;
        var first = ModPow(mul, multiple, MOD);
        var second = ModPow(mul, multiple + 1, MOD);
        while (pq.Count > 0)
        {
            var i = pq.Dequeue();
            nums[i] = (int)(nums[i] * (remain > 0 ? second : first) % MOD);
            remain--;
        }
        return nums;
    }

    /// <summary>
    /// x ^ y mod p
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    static long ModPow(long x, long y, long p)
    {
        long res = 1;
        while (y > 0)
        {
            if (y % 2 == 1) res = res * x % p;
            y >>= 1;
            x = x * x % p;
        }
        return res;
    }
}
