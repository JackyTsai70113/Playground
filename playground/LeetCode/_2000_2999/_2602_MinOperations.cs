namespace playground.LeetCode._2000_2999;

public class _2602_MinOperations
{
    public static IList<long> MinOperations(int[] nums, int[] queries)
    {
        Array.Sort(nums);
        int n = nums.Length, l = 0, r = n;
        var res = new List<long>();
        long[] cache = new long[n];
        for (int i = 0; i < n; ++i)
        {
            cache[i] += i == 0 ? nums[0] : cache[i - 1] + nums[i];
        }
        foreach (var q in queries)
        {
            l = 0; r = n;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (nums[m] <= q)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            if (l > 0)
            {
                res.Add((long)l * q - cache[l - 1] + (cache[n - 1] - cache[l - 1]) - (long)q * (n - l));
            }
            else
            {
                res.Add(cache[n - 1] - (long)n * q);
            }
        }
        return res;
    }
}
