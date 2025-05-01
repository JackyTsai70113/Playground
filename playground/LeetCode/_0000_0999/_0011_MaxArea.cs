namespace playground.LeetCode._0000_0999;

public class _0011_MaxArea
{
    public static int MaxArea(int[] A)
    {
        int l = 0, r = A.Length - 1, res = 0;
        while (l < r)
        {
            res = Math.Max(res, Math.Min(A[l], A[r]) * (r - l));
            if (A[l] < A[r])
                l++;
            else
                r--;
        }
        return res;
    }
}
