using playground.Helpers;

namespace playground.LeetCode._3000_3999;

public class _3591_CheckPrimeFrequency
{
    public static bool CheckPrimeFrequency(int[] nums)
    {
        var d = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            d[num] = d.GetValueOrDefault(num) + 1;
        }

        int n = d.Values.Max();
        var isPrime = MathHelper.GetPrimesSieve(n);

        foreach (var f in d.Values)
        {
            if (isPrime[f])
                return true;
        }
        return false;
    }
}
