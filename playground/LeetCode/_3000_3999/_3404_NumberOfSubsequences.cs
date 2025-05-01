namespace playground._3400_3499;

public class _3404_NumberOfSubsequences
{
    // p   q   r   s
    // 0 1 2 3 4 5 6
    // p * r == q * s
    // p / q == s / r
    public static long NumberOfSubsequences(int[] nums)
    {
        int n = nums.Length;
        var cnt = new Dictionary<double, int>();
        long res = 0;
        for (int i = 3; i <= n - 4; i++)
        {
            int q = i - 1;
            for (int p = 0; p <= q - 2; p++)
            {
                double key = (double)nums[p] / nums[q];
                cnt[key] = cnt.GetValueOrDefault(key) + 1;
            }
            int r = i + 1;
            for (int s = r + 2; s < n; s++)
            {
                double key = (double)nums[s] / nums[r];
                res += cnt.GetValueOrDefault(key);
            }
        }
        return res;
    }
}
