using playground.LeetCode.Helpers;

namespace playground;

public class _3154_WaysToReachStair
{
    /// <summary>
    /// https://leetcode.com/problems/find-number-of-ways-to-reach-the-k-th-stair
    /// </summary>
    public static int WaysToReachStair(int k)
    {
        int n = 32;
        var comb = MathHelper.GetCombination(n);
        k--;
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            var total = (1 << i) - 1;
            if (total - i - 1 <= k && k <= total)
            {
                res += comb[i + 1, total - k];
            }
        }
        return res;
    }
}
