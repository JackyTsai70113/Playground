namespace playground;

public class MaximumTotalDamage3186
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-total-damage-with-spell-casting
    /// </summary>
    public static long MaximumTotalDamage(int[] power)
    {
        Dictionary<long, long> freq = new();
        foreach (var damage in power)
        {
            freq[damage] = freq.ContainsKey(damage) ? freq[damage] + 1 : 1;
        }
        var arr = new List<long>(freq.Keys);
        arr.Sort();

        int n = arr.Count;
        if (n == 1)
            return arr[0] * freq[arr[0]];

        long max = 0;
        var dp = new long[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = Math.Max(max, arr[i] * freq[arr[i]]);
            for (int j = i - 1; j >= 0; j--)
            {
                if (arr[j] < arr[i] - 2)
                {
                    dp[i] = Math.Max(dp[i], arr[i] * freq[arr[i]] + dp[j]);
                    break;
                }
            }
            max = Math.Max(max, dp[i]);
        }
        return max;
    }
}
