namespace playground;

public class MaxArea_0011
{
    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water
    /// </summary>
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
