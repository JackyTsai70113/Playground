namespace playground;

public class Insert_0057
{
    /// <summary>
    /// https://leetcode.com/problems/insert-interval
    /// </summary>
    public static int[][] Insert(int[][] A, int[] a)
    {
        int n = A.Length, left, right;
        var (l, r) = (-1, n - 1); // 極右值
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (A[m][0] <= a[0])
                l = m;
            else
                r = m - 1;
        }
        if (l >= 0 && A[l][1] >= a[0])
            a[0] = A[l][0];
        else
            l++;
        left = l;

        (l, r) = (0, n); // 極左值
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (A[m][1] >= a[1])
                r = m;
            else
                l = m + 1;
        }
        if (l < n && A[l][0] <= a[1])
            a[1] = A[l][1];
        else
            l--;
        right = l;
        var res = A.ToList();
        res.RemoveRange(left, right - left + 1);
        res.Insert(left, a);
        return res.ToArray();
    }
}
