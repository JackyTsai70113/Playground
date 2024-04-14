namespace playground;

public class MaximumPrimeDifference3115
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-prime-difference
    /// </summary>
    public static int MaximumPrimeDifference(int[] nums)
    {
        int n = nums.Max();
        bool[] isPrime = new bool[n + 1];
        Array.Fill(isPrime, true);
        isPrime[1] = false;
        for (int i = 2; i <= n; ++i)
        {
            if (!isPrime[i]) continue;
            for (int j = i * 2; j <= n; j += i)
                isPrime[j] = false;
        }
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
}
