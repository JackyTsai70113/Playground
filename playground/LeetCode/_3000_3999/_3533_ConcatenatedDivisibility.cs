namespace playground._3500_3599;

public class _3533_ConcatenatedDivisibility
{
    private int n;
    private int k;
    private int total;
    private int[] nums;
    private int[] multiplicationWithLen;
    private Dictionary<long, List<int>> dp;

    public int[] ConcatenatedDivisibility(int[] nums, int k)
    {
        int n = nums.Length;
        this.n = n;
        this.k = k;
        this.total = (1 << n) - 1;
        this.nums = nums;

        int[] multiplicationWithLen = new int[n];
        for (int i = 0; i < n; i++)
        {
            int digit = (int)Math.Log10(nums[i]) + 1;
            int m = 1;
            for (int d = 0; d < digit; d++)
                m = m * 10 % k;
            multiplicationWithLen[i] = m;
        }
        this.multiplicationWithLen = multiplicationWithLen;

        dp = new();
        var list = Solve(0, 0);
        if (list == null)
            return Array.Empty<int>();
        return list.ToArray();
    }

    private List<int> Solve(int mask, int remainder)
    {
        if (mask == total)
            return remainder == 0 ? new List<int>() : null;
        long key = mask * 100 + remainder;
        if (dp.ContainsKey(key))
            return dp[key];

        List<int> res = null;
        for (int i = 0; i < n; i++)
        {
            int bit = 1 << i;
            if ((mask & bit) != 0)
                continue;
            int newRemainder = mask == 0 ?
                nums[i] % k :
                (remainder * multiplicationWithLen[i] + nums[i]) % k;

            List<int> tail = Solve(mask | bit, newRemainder);
            if (tail != null)
            {
                List<int> candidate = new();
                candidate.Add(nums[i]);
                candidate.AddRange(tail);
                if (res == null || candidate[0] - res[0] < 0)
                    res = candidate;
            }
        }

        return dp[key] = res;
    }
}
