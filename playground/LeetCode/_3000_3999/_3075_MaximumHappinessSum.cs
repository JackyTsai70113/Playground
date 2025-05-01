namespace playground;

public class _3075_MaximumHappinessSum
{
    /// <summary>
    /// https://leetcode.com/problems/maximize-happiness-of-selected-children
    /// </summary>
    public static long MaximumHappinessSum(int[] A, int k)
    {
        long res = 0;
        Array.Sort(A);
        int i = A.Length - 1, minus = 0;
        for (int j = 0; j < k; j++)
        {
            res += Math.Max(0, A[i--] - minus);
            minus++;
        }
        return res;
    }
}
