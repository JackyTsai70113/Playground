namespace playground.DynamicProgramming;

public class MinimumCostClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-to-make-all-characters-equal
    /// </summary>
    public static long MinimumCost(string s)
    {
        long res = 0;
        for (int i = 1; i < s.Length; ++i)
            res += s[i - 1] == s[i] ? 0 : Math.Min(i, s.Length - i);
        return res;
    }
}
