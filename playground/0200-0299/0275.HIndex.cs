namespace playground;

public class HIndex_0275
{
    /// <summary>
    /// https://leetcode.com/problems/h-index-ii
    /// </summary>
    public static int HIndex(int[] A)
    {
        int n = A.Length, l = 0, r = n;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (A[m] >= n - m)
                r = m;
            else
                l = m + 1;
        }
        return n - l;
    }
}
