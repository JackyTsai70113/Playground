namespace playground;

public class _3091_MinOperations
{
    /// <summary>
    /// https://leetcode.com/problems/apply-operations-to-make-sum-of-array-greater-than-or-equal-to-k
    /// </summary>
    public static int MinOperations(int k)
    {
        int a = (int)Math.Sqrt(k);
        int b = a;
        while (a * b < k) b++;
        return a + b - 2;
    }
}
