namespace playground;

public class IsPowerOfThree0326
{
    /// <summary>
    /// https://leetcode.com/problems/power-of-three
    /// </summary>
    public static bool IsPowerOfThree(int n)
    {
        return n <= 0 ? false : n == Math.Pow(3, Math.Round(Math.Log(n) / Math.Log(3)));
    }
}
