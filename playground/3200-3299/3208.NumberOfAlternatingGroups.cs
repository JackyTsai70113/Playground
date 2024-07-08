namespace playground;

public class NumberOfAlternatingGroups3208
{
    /// <summary>
    /// https://leetcode.com/problems/alternating-groups-ii
    /// </summary>
    public static int NumberOfAlternatingGroups(int[] A, int k)
    {
        int n = A.Length;
        var arr = new int[n + k - 1];
        for (int i = 0; i < n + k - 1; i++)
        {
            if (i < n)
                arr[i] = A[i];
            else
                arr[i] = A[i - n];
        }
        int res = 0, l = 0;
        for (int r = 1; r < arr.Length; r++)
        {
            if (arr[r] == arr[r - 1])
            {
                if (r - l >= k)
                {
                    res += r - l - k + 1;
                }
                l = r;
            }
        }
        if (n - 1 - l >= 0)
        {
            res += n - l;
        }
        return res;
    }
}
