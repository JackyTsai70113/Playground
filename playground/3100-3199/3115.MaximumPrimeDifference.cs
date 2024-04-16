namespace playground;

public class MaximumPrimeDifference3115
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-prime-difference
    /// </summary>
    public static int MaximumPrimeDifference(int[] nums)
    {
        int n = nums.Max();
        bool[] isPrime = EratosthenesSieve(n);
        int l = -1, r = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (isPrime[nums[i]])
            {
                l = i;
                break;
            }
        }
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (isPrime[nums[i]])
            {
                r = i;
                break;
            }
        }
        return r - l;
    }

    private static bool[] EratosthenesSieve(int n)
    {
        var isPrime = Enumerable.Repeat(true, n + 1).ToArray();
        isPrime[0] = isPrime[1] = false;
        for (int p = 2; p * p <= n; ++p)
        {
            if (!isPrime[p]) continue;
            for (int i = p * 2; i <= n; i += p)
                isPrime[i] = false;
        }
        return isPrime;
    }
}
