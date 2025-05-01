namespace playground._3300_3399;

public class _3355_IsZeroArray
{
    public static bool IsZeroArray(int[] nums, int[][] queries)
    {
        var A = new int[nums.Length];
        foreach (var q in queries)
        {
            A[q[0]]++;
            if (q[1] < nums.Length - 1)
                A[q[1] + 1]--;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0)
            {
                A[i] += A[i - 1];
            }
            if (A[i] < nums[i])
            {
                return false;
            }
        }
        return true;
    }
}
