namespace playground_1500_1599;

public class _1590_MinSubarray_cs
{
    public static int MinSubarray(int[] nums, int p)
    {
        int n = nums.Length;
        long sum = 0, cur = 0;
        for (int i = 0; i < n; i++)
        {
            sum = (sum + nums[i]) % p;
        }
        if (sum == 0)
            return 0;
        var remain = new Dictionary<long, int>();
        remain[0] = -1;
        int res = n;
        for (int i = 0; i < n; i++)
        {
            cur = (cur + nums[i]) % p;
            if (cur >= sum && remain.ContainsKey(cur - sum))
            {
                res = Math.Min(res, i - remain[cur - sum]);
            }
            else if (remain.ContainsKey(cur + p - sum))
            {

                res = Math.Min(res, i - remain[cur + p - sum]);
            }
            remain[cur] = i;
        }
        return res == n ? -1 : res;
    }
}
