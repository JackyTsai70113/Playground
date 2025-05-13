namespace playground.LeetCode._3000_3999;

public class _3301_MaximumTotalSum
{
    public static long MaximumTotalSum(int[] A)
    {
        Array.Sort(A);
        int last = A[^1];
        long res = last;
        for (int i = A.Length - 2; i >= 0; i--)
        {
            last = Math.Min(A[i], last - 1);
            if (last == 0)
                return -1;
            res += last;
        }
        return res;
    }
}
