namespace playground.LeetCode._0000_0999;

public class _0326_IsPowerOfThree
{
    /// <summary>
    /// https://leetcode.com/problems/power-of-three
    /// </summary>
    public static bool IsPowerOfThree(int n)
    {
        return n > 0 && n == Math.Pow(3, Math.Round(Math.Log(n) / Math.Log(3)));
    }
}
